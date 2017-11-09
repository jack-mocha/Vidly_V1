using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember] //Disabled - Ideally we should have only 1 way to create a customer, but now we have both mvc action and api. This is disabled because the custom validation is using Customer instead of CustomerDto
        public DateTime? BirthDate { get; set; }
    }
}