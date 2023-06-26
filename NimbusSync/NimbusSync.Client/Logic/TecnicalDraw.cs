namespace NimbusSync.Client
{
    public class TecnicalDraw
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateOnly? CreationDate { get; set; }
        public string? Author { get; set; }
        public string? FilePath { get; set; }

        const string HAS_NO_AUTHOR = "None";

        public TecnicalDraw() { }

        public TecnicalDraw(string? code, string? name, string? description, DateOnly? creationDate, string? author, string? filePath)
        {
            Code = code;
            Name = name;
            Description = description;
            CreationDate = creationDate;
            Author = author;
            FilePath = filePath;
        }

        public TecnicalDraw(string? code, string? name, string? description, string? filePath)
        {
            Code = code;
            Name = name;
            Description = description;
            if (!File.Exists(filePath))
            {
                Author = HAS_NO_AUTHOR;
                CreationDate = null;
            }

            FilePath = filePath;

            SetAuthorUsingPath();
            SetCreationDateUsingPath();
        }

        private void SetAuthorUsingPath()
        {
            try
            {
                FileInfo fileInfo = new FileInfo(FilePath);

                string author = fileInfo.GetAccessControl().GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();

                if (string.IsNullOrEmpty(author))
                {
                    Author = HAS_NO_AUTHOR;
                    return;
                }

                author = author.Split("\\", StringSplitOptions.RemoveEmptyEntries).Last();

                Author = author;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void SetCreationDateUsingPath()
        {
            if (!File.Exists(FilePath))
            {
                CreationDate = null;
                return;
            }

            try
            {
                var creationDateTime = DateOnly.FromDateTime(File.GetCreationTime(FilePath));
                CreationDate = creationDateTime;
            }
            catch (Exception e)
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
