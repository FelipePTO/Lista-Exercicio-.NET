using pardedesenhoModel;
using System.ComponentModel.DataAnnotations; 
using System.Collections.Generic;
using System;

namespace funcaoValidacao {
    public class Validacoes{
        public bool validainfomacoes(PardeDesenho d){
            ValidationContext context = new ValidationContext(d, null, null); 
            List<ValidationResult> results = new List<ValidationResult>(); 
            bool valid = Validator.TryValidateObject(d, context, results, true); 

            if(!valid){
                foreach (ValidationResult vr in results) 
                { 
                    Console.WriteLine(vr.ErrorMessage); 
                } 
            }

            return valid;

        }
    }
}