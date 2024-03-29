﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuniKitchen.Models
{
        [Table("Products")]
        public class Product
        {

            [Display(Name = "ID of the Product")]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Product_Id { get; set; }


            [Display(Name = "Name of the Product")]
            [Required]
            [StringLength(80, ErrorMessage = "{0} cannot have more than {1} characters.")]
            [MinLength(3, ErrorMessage = "{0} should have a minimum of {1} characters.")]
            public string Product_Name { get; set; }


            [Display(Name = "Description")]
            public string Product_Description { get; set; }


            [Display(Name = "Price per unit")]
            [Required]
            [Range(0.0, 500.00, ErrorMessage = "{0} has to be between Rs. {1} and Rs. {2}")]
            public decimal Product_Price { get; set; }


            [Required]
            [Display(Name = "Product Quantity")]
            public string Product_Quantity { get; set; }


            /// <summary>
            ///     Size of the Product
            /// </summary>
            /// <remarks>
            ///     This is mapped to an enumeration of Sizes
            /// </remarks>
            [Display(Name = "Size")]
            [Column(TypeName = "varchar(20)")]
            public string Product_Size { get; set; }



            [Display(Name = "Product Image")]
            [NotMapped]
            public IFormFile Product_Image { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "{0} should have a minimum of {1} characters")]
        [StringLength(30, ErrorMessage = "{0} cannot have more than {1} characters in length.")]
        [Display(Name = "Product Category")]
        public string Product_Category { get; set; }


        // #region Navigational Properties to the Category Model

        //[ForeignKey(nameof(Product.Category))]
        //public short CategoryId { get; set; }

        //public Category Category { get; set; }

        //#endregion
    }
}
