namespace NimbusSync.Client
{
    public class TecDraw
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? Author { get; set; }
        public string? FilePath { get; set; }
        public byte[]? ByteFile => GetFile();

        const string HAS_NO_AUTHOR = "None";

        public TecDraw(string Id, string Name, string FilePath)
        {
            this.Id = Id;
            this.Name = Name;

            if (!File.Exists(FilePath))
            {
                Author = HAS_NO_AUTHOR;
                CreationDate = null;                
            }

            SetAuthorUsingPath();
            SetCreationDateUsingPath();
        }

        private void SetAuthorUsingPath()
        {
            try
            {
                FileInfo fileInfo = new FileInfo(FilePath);

                string author = fileInfo.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
                
                if(string.IsNullOrEmpty(author))
                {
                    Author = HAS_NO_AUTHOR;
                    return;
                }

                Author = author;

            } catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void SetCreationDateUsingPath()
        {
            if(!File.Exists(FilePath))
            {
                CreationDate = null;
                return;
            }

            try
            {
                var creationDateTime = File.GetCreationTime(FilePath);
                CreationDate = creationDateTime;
            } catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public byte[]? GetFile()
        {
            if (!File.Exists(FilePath)) return null;

            return File.ReadAllBytes(FilePath);
        }
    }
}
