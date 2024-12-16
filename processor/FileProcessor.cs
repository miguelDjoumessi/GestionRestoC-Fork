using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.processor
{
    class FileProcessor
    {
        public string? UploadedFile(OpenFileDialog ofd, string context = "")
        {
            string destinationDirectory = "";
            using (ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imge Files (*.jpg)|*.jpg|(*.png)|*.png"; // Filtre pour types de fichiers
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedfilePath = ofd.FileName;
                    string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"));
                    //string targetDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UploadedFiles"); // combine le chemin vers le file excutable du projet et le nom repertoire que nous voulons creer
                    string uploadedFileDirectory = Path.Combine(projectRoot, "UploadedFiles");

                    if(string.IsNullOrEmpty(context))
                    {
                        uploadedFileDirectory += @"\" + context; 
                    }

                    if (!Directory.Exists(uploadedFileDirectory))
                    {
                        Directory.CreateDirectory(uploadedFileDirectory);
                    }

                    DirectoryInfo directoryInfo = new DirectoryInfo(uploadedFileDirectory);
                    DirectorySecurity ds = directoryInfo.GetAccessControl();
                    ds.AddAccessRule(new FileSystemAccessRule("AMD", FileSystemRights.Write, AccessControlType.Allow));
                    directoryInfo.SetAccessControl(ds);

                    // Renommage du fichier recuperer
                    string uniqueId = Guid.NewGuid().ToString();
                    string fileName = Path.GetFileName(selectedfilePath);
                    string newFileName = fileName.Replace(Path.GetExtension(fileName), "") + "__" + uniqueId + Path.GetExtension(fileName);

                    // copy du fichier dans le repetoire cible
                    destinationDirectory = Path.Combine(uploadedFileDirectory, newFileName);
                    File.Copy(selectedfilePath, destinationDirectory, overwrite: true);
                }

                return destinationDirectory;
            }
        }
    }
}
