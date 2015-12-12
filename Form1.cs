using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryRenamer
{
    /// <summary>
    /// Classe de la fenêtre principale de l'application
    /// </summary>
    public partial class MainWindow : Form
    {
        #region Main Application Constructor
        /// <summary>
        /// Constructor of the window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            selectAllCheckboxRenamerPage.Enabled = false;
            selectAllCheckboxIncrementalRenamerPage.Enabled = false;
        }
        #endregion
        #region Global Variables
        List<string> listOfSubDir = new List<string>();
        bool firstClickSelectAllItemsCheckListBox = true;
        #endregion
        #region Globalized Methods
        /// <summary>
        /// Get a list of all subdirectories from the selected one
        /// </summary>
        /// <param name="inputDirectory"></param>
        /// <returns>Returns a list of string which corresponds of the paths of directories we've got</returns>
        public List<string> getSubDirectories(string inputDirectory)
        {
            if (inputDirectory != "D:\\System Volume Information" && inputDirectory != "D:\\$RECYCLE.BIN")
            {
                try
                {
                    List<string> directories = new List<string>(Directory.EnumerateDirectories(inputDirectory));
                    foreach (string dir in directories)
                    {
                        if (dir != "D:\\System Volume Information" && dir != "D:\\$RECYCLE.BIN")
                        listOfSubDir.Add(dir);
                        getSubDirectories(dir);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    richTextBoxRenamerPage.ForeColor = Color.Red;
                    richTextBoxRenamerPage.AppendText("!!! Attention, parmis les dossiers affichés certains sont des dossiers protégés du sytème et ne doivent pas être modifiés !!!");
                }

            }       
            return listOfSubDir;
        }

        /// <summary>
        /// Display the list we've got previously
        /// </summary>
        /// <param name="inputListOfSubDir"></param>
        public void displaySubDirectories(List<string>inputListOfSubDir)
        {
            if(renamerPage.ContainsFocus)
            {
                foreach(string dir in inputListOfSubDir)
                {
                    checkedListBoxRenamerPage.Items.Add(dir);
                }
            }
            else
            {
                foreach (string dir in inputListOfSubDir)
                {
                    checkedListBoxIncrementalRenamerPage.Items.Add(dir);
                }
            }
        }

        private void openFolder()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                listOfSubDir.Clear();
                if (renamerPage.ContainsFocus)
                {
                    // Clearing items                    
                    richTextBoxRenamerPage.Clear();
                    checkedListBoxRenamerPage.Items.Clear();
                    selectAllCheckboxRenamerPage.Enabled = true;
                    selectAllCheckboxRenamerPage.Checked = false;
                }
                else
                {
                    // Clearing items
                    richTextBoxIncrementalRenamerPage.Clear();
                    checkedListBoxIncrementalRenamerPage.Items.Clear();
                    selectAllCheckboxIncrementalRenamerPage.Enabled = true;
                    selectAllCheckboxIncrementalRenamerPage.Checked = false;
                }
                // Call the getter and displayer of the sub directories
                getSubDirectories(folderBrowserDialog.SelectedPath);
                displaySubDirectories(listOfSubDir);
            }
        }

        private void selectAll()
        {
            if (renamerPage.ContainsFocus)
            {
                // If the checkBox is checked, we checked all the elements of the listCheckedBox
                if (firstClickSelectAllItemsCheckListBox)
                {
                    for (int i = 0; i < checkedListBoxRenamerPage.Items.Count; i++)
                    {
                        checkedListBoxRenamerPage.SetItemChecked(i, true);
                    }
                    renameButtonRenamerPage.Enabled = true;
                    firstClickSelectAllItemsCheckListBox = false;
                }
                // Else we unchecked them
                else
                {
                    for (int i = 0; i < checkedListBoxRenamerPage.Items.Count; i++)
                    {
                        checkedListBoxRenamerPage.SetItemChecked(i, false);
                    }
                    renameButtonRenamerPage.Enabled = false;
                    firstClickSelectAllItemsCheckListBox = true;
                }
            }
            else
            {
                // If the checkBox is checked, we checked all the elements of the listCheckedBox
                if (firstClickSelectAllItemsCheckListBox)
                {
                    for (int i = 0; i < checkedListBoxIncrementalRenamerPage.Items.Count; i++)
                    {
                        checkedListBoxIncrementalRenamerPage.SetItemChecked(i, true);
                    }
                    renameButtonIncrementalRenamerPage.Enabled = true;
                    firstClickSelectAllItemsCheckListBox = false;
                }
                // Else we unchecked them
                else
                {
                    for (int i = 0; i < checkedListBoxIncrementalRenamerPage.Items.Count; i++)
                    {
                        checkedListBoxIncrementalRenamerPage.SetItemChecked(i, false);
                    }
                    renameButtonIncrementalRenamerPage.Enabled = false;
                    firstClickSelectAllItemsCheckListBox = true;
                }
            }
        }
        #endregion
        #region First Tab Methods
        private void openButtonRenamerPage_Click(object sender, EventArgs e)
        {
            // Call the openFolder method
            openFolder();
        }

        private void selectAllCheckboxRenamerPage_CheckedChanged(object sender, EventArgs e)
        {
            selectAll();
        }

        private void renameButtonRenamerPage_Click(object sender, EventArgs e)
        {
            #region Initialisation
            // Define a regex to get the parent directory
            String pattern = @"(\d+)\\(JPG|RAW|Origine)$";
            // Reset the richTextBox
            richTextBoxRenamerPage.Clear();
            // Instanciate counters
            int counterTotalSelected = checkedListBoxRenamerPage.CheckedItems.Count, counterTotalRenamed = 0;
            // Set the progressBar maximum at the number of the checked items
            progressBarRenamerPage.Maximum = counterTotalSelected;
            // A list of directories which might not be renamed
            List<string> rejectedDirectories = new List<string>();
            #endregion
            #region Process
            foreach (string item in checkedListBoxRenamerPage.CheckedItems)
            {
                // perform a step even if the try fails because we need to do it on each element selected
                progressBarRenamerPage.PerformStep();
                #region Try a regex match
                // Try to match on one of those directories JPG|RAW|Origine, and so to get the parent directory.
                try
                {
                    #region Initialisation
                    // get matches
                    var matches = Regex.Matches(item, pattern);
                    // get sub directory
                    StringBuilder subDirectory = new StringBuilder(Convert.ToString(item));
                    subDirectory.Remove(0, subDirectory.Length - 3);
                    // get parent directory
                    StringBuilder parentDirectory = new StringBuilder(Convert.ToString(matches[0].Groups[1].ToString()));
                    // get directory
                    StringBuilder directory = new StringBuilder(item);
                    #endregion
                    #region Do the rename on the string
                    // if the sub directory is JPG or RAW
                    if (subDirectory.ToString() == "JPG" || subDirectory.ToString() == "RAW")
                    {
                        directory.Insert(directory.Length - 3, parentDirectory + " ");
                        richTextBoxRenamerPage.AppendText(directory.ToString() + "\n");
                    }
                    // else the sub directory must be Origine
                    else
                    {
                        directory.Insert(directory.Length - 7, parentDirectory + " ");
                        richTextBoxRenamerPage.AppendText(directory.ToString() + "\n");
                    }
                    #endregion
                    #region Rename the directory
                    // Try to rename the directory
                    try
                    {
                        Directory.Move(item, directory.ToString());
                    }
                    // if it fails, catch it, warn the user and force to continue
                    catch (Exception)
                    {
                        richTextBoxRenamerPage.Clear();
                        rejectedDirectories.Add(item);
                        MessageBox.Show(item + "\nLe dossier ci-dessus est sélectionné mais il n'existe pas ou plus !");
                        continue;
                    }
                    #endregion
                    counterTotalRenamed++;
                }
                #endregion
                #region Catch Exception
                // if there is no match, to avoid a system exception, catch it and force to continue
                catch (System.ArgumentOutOfRangeException)
                {
                    continue;
                }
                #endregion
            }
            #endregion

            richTextBoxRenamerPage.AppendText("\n\n" + counterTotalRenamed + " dossiers ont été renommés sur un total de " + counterTotalSelected + " dossier sélectionnés !\n\n");
            richTextBoxRenamerPage.AppendText("NOTE : les dossiers sélectionnés n'ayant pas de sous-dossiers ou pas de noms de sous-dossiers conformes n'ont pas été traités. \n\n");

            #region Display Rejected Directories
            if (rejectedDirectories.Count != 0)
            {
                richTextBoxRenamerPage.AppendText("Voici la liste des dossiers qui n'ont pas été traités :\n\n");
                foreach (string rejDir in rejectedDirectories)
                {
                    richTextBoxRenamerPage.AppendText(rejDir + "\n");
                }
            }
            #endregion
        }
        
        private void checkedListBoxRenamerPage_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(checkedListBoxRenamerPage.CheckedItems.Count == checkedListBoxRenamerPage.Items.Count-1)
            {
                selectAllCheckboxRenamerPage.Checked = true;
                renameButtonRenamerPage.Enabled = true;
            }
            if(checkedListBoxRenamerPage.CheckedItems.Count == 1)
            {
                selectAllCheckboxRenamerPage.Checked = false;
                renameButtonRenamerPage.Enabled = false;
            }
        }
        #endregion
        #region Second Tab Methods
        private void openButtonIncrementalRenamerPage_Click(object sender, EventArgs e)
        {
            // Call the openFolder method
            openFolder();
        }

        private void selectAllCheckboxIncrementalRenamerPage_CheckedChanged(object sender, EventArgs e)
        {
            selectAll();
        }

        private void numberInitialDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            string output = numberInitialDirectoryTextBox.Text;
            if (output != "")
            {
                try
                {
                    Convert.ToInt16(output);
                    if (checkedListBoxIncrementalRenamerPage.Items.Count > 0)
                    {
                        renameButtonIncrementalRenamerPage.Enabled = true;
                    }
                }
                catch (System.FormatException)
                {
                    renameButtonIncrementalRenamerPage.Enabled = false;
                    MessageBox.Show("Le numéro du dossier entré n'est pas valide, il doit corresspondre à un entier à 3 chiffres tel que le modèle d'entrée");
                    numberInitialDirectoryTextBox.Text = "001";
                } 
            }
            else
            {
                renameButtonIncrementalRenamerPage.Enabled = false;
            }
        }

        private void renameButtonIncrementalRenamerPage_Click(object sender, EventArgs e)
        {
            #region Initialisation
            // Get the input number of the initial directory to base the incrementation
            StringBuilder inputNumber = new StringBuilder(numberInitialDirectoryTextBox.Text);
            // Define a regex to get the film directory
            String pattern = @"\\(\d{3})$";
            // Reset the richTextBox
            richTextBoxIncrementalRenamerPage.Clear();
            // Instanciate counters
            int counterTotalSelected = checkedListBoxIncrementalRenamerPage.CheckedItems.Count, counterTotalRenamed = 0;
            // Set the progressBar maximum at the number of the checked items
            progressBarIncrementalRenamerPage.Maximum = counterTotalSelected;
            // A list of directories which might not be renamed
            List<string> rejectedDirectories = new List<string>();
            // A boolean to know if it's the first Iteration of the foreach
            bool firstIteration = true;
            #endregion
            #region Process
            foreach (string item in checkedListBoxIncrementalRenamerPage.CheckedItems)
            {
                // perform a step even if the try fails because we need to do it on each element selected
                progressBarIncrementalRenamerPage.PerformStep();
                #region First Iteration
                // for the first iteration, convert the string into an int, then convert it into a string again
                // usefull to avoid a 00 on the first directory we rename
                if(firstIteration)
                {
                    int inter = Convert.ToInt32(inputNumber.ToString());
                    inputNumber.Clear();
                    inputNumber.Append(inter);
                    firstIteration = false;
                }
                #endregion
                #region Try a regex match
                // Try to match on one of those directories JPG|RAW|Origine, and so to get the parent directory.
                try
                {
                    #region Initialisation
                    // get matches
                    var matches = Regex.Matches(item, pattern);
                    // get sub directory
                    StringBuilder subDirectory = new StringBuilder(Convert.ToString(item));
                    subDirectory.Remove(0, subDirectory.Length - 3);
                    // get parent directory
                    StringBuilder parentDirectory = new StringBuilder(Convert.ToString(matches[0].Groups[1].ToString()));
                    // get directory
                    StringBuilder directory = new StringBuilder(item);
                    #endregion
                    #region Do the rename on the string
                    // convert into an int to eval in which slice the film is
                    Int16 inputNumberInInt = Convert.ToInt16(inputNumber.ToString());
                    directory.Remove(directory.Length - 3, 3);
                    if(inputNumberInInt > 1 && inputNumberInInt <10)
                    {
                        directory.Append("00"+ inputNumber.ToString());
                    }
                    else if (inputNumberInInt >= 10 && inputNumberInInt < 100)
                    {
                        directory.Append("0" + inputNumber.ToString());
                    }
                    else if(inputNumberInInt == 1)
                    {
                        directory.Append("00" + inputNumber.ToString());
                    }
                    else
                    {
                        directory.Append(inputNumber.ToString());
                    }
                    richTextBoxIncrementalRenamerPage.AppendText(directory.ToString() + "\n");
                    #endregion
                    #region Rename the directory
                    // Try to rename the directory
                    try
                    {
                        Directory.Move(item, directory.ToString());
                    }
                    // if it fails, catch it, warn the user and force to continue
                    catch (Exception)
                    {
                        richTextBoxIncrementalRenamerPage.Clear();
                        rejectedDirectories.Add(item);
                        MessageBox.Show(item + "\nLe dossier ci-dessus est sélectionné mais il n'existe pas ou plus !");
                        continue;
                    }
                    #endregion
                    #region Incrementation
                    int interSt = Convert.ToInt32(inputNumber.ToString())+1;
                    inputNumber.Clear();
                    inputNumber.Append(interSt);
                    counterTotalRenamed++;
                    #endregion
                }
                #endregion
                #region Catch Exception
                // if there is no match, to avoid a system exception, catch it and force to continue
                catch (System.ArgumentOutOfRangeException)
                {
                    continue;
                }
                #endregion
            }
            #endregion

            richTextBoxIncrementalRenamerPage.AppendText("\n\n" + counterTotalRenamed + " dossiers ont été renommés sur un total de " + counterTotalSelected + " dossier sélectionnés !\n\n");
            richTextBoxIncrementalRenamerPage.AppendText("NOTE : les dossiers sélectionnés n'ayant pas de sous-dossiers ou pas de noms de sous-dossiers conformes n'ont pas été traités. \n\n");

            #region Display Rejected Directories
            if (rejectedDirectories.Count != 0)
            {
                richTextBoxIncrementalRenamerPage.AppendText("Voici la liste des dossiers qui n'ont pas été traités :\n\n");
                foreach (string rejDir in rejectedDirectories)
                {
                    richTextBoxIncrementalRenamerPage.AppendText(rejDir + "\n");
                }
            }
            #endregion
        }

        private void checkedListBoxIncrementalRenamerPage_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBoxIncrementalRenamerPage.CheckedItems.Count == checkedListBoxIncrementalRenamerPage.Items.Count - 1)
            {
                selectAllCheckboxIncrementalRenamerPage.Checked = true;
                renameButtonIncrementalRenamerPage.Enabled = true;
            }
            if (checkedListBoxIncrementalRenamerPage.CheckedItems.Count == 1)
            {
                selectAllCheckboxIncrementalRenamerPage.Checked = false;
                renameButtonIncrementalRenamerPage.Enabled = false;
            }
        }
        #endregion
    }
}
