﻿namespace NimbusSync.Models.DTO
{
    public class TecnicalDrawDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? AuthorId { get; set; }
    }
}
