﻿using System.ComponentModel.DataAnnotations;

namespace Task_PurpleBuzz.Areas.Admin.ViewModels.ServiceComponent
{
    public class ServiceComponentCreateVM
    {
        [Required(ErrorMessage ="Title is required")]
        [MaxLength(20,ErrorMessage ="Header mustn't exceed 20 characters")]
        public string Title { get; set; }

        [MaxLength(20, ErrorMessage = "Subtitle mustn't exceed 20 characters")]
        public string Subtitle { get; set; }

        [Required(ErrorMessage = "Decription is required")]
        [MinLength(10,ErrorMessage ="Description must consist of at least 10 characters")]
        [MaxLength(100,ErrorMessage ="Description mustn't exceed 100 characters")]
        public string Desc { get; set; }
    }
}
