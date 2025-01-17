﻿using System.ComponentModel.DataAnnotations;
namespace Entities.Dto.Fridge
{
    public abstract class FridgeForManipulationDto
    {
        [Required(ErrorMessage = "Fridge name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Owner name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Owner name is 30 characters.")]
        public string OwnerName { get; set; }
    }
}
