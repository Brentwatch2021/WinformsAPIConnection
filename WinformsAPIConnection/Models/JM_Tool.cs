﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinformsAPIConnection.Models
{
    public class JM_Tool
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool CheckedInOutStatus { get; set; }

        // History might implement later
        public string History { get; set; }

        // ID of the user the tool is assigned to 
        public int AssignedTo { get; set; }

        public string Tool_Image_Path { get; set; }

        public string Tool_Image_MIME_Type { get; set; }

        [NotMapped]
        public IFormFile Image_Of_Tool { get; set; }
    }
}
