public void ToJPG(string folder)
        {

            foreach (string file in System.IO.Directory.GetFiles(folder))
            {
                string extension = System.IO.Path.GetExtension(file);
                if (extension == ".png")
                {
                    string name = System.IO.Path.GetFileNameWithoutExtension(file);
                    string path = System.IO.Path.GetDirectoryName(file);
                    Image png = Image.FromFile(file);
                    png.Save(path + @"/" + name + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    png.Dispose();
                }
            }
        }
