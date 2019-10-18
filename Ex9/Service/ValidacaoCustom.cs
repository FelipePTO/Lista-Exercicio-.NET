using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
using System.ComponentModel.DataAnnotations;  
using System.Text.RegularExpressions; 
using DesenhoModel;
using pardedesenhoModel;

namespace VerificaFilhoCustom{
    public class VerificaFilhoVazio : ValidationAttribute{

        public Desenho Filho {get;set;}
        public int TamanhoPeso {get;set;}

        public VerificaFilhoVazio()
        {
            
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)  
        {
            //Verifica se não tá chegando valor Null, pois é do tipo required, então tem que existir
            if (value != null)  
            {  

                //Então pega as informações dos atributos do contexto que estou validando
                var filhoobjeto = validationContext.ObjectType.GetProperty("Filhos");
                var propertyValue = filhoobjeto.GetValue(validationContext.ObjectInstance, null) as Desenho[];

                var pesoobjeto = validationContext.ObjectType.GetProperty("Peso");
                var PesoValue = pesoobjeto.GetValue(validationContext.ObjectInstance, null);


                var tamanhoArray = 0;

                //Verifica se não tem filhos
                if(propertyValue == null){
                    tamanhoArray=0;
                }else{
                    tamanhoArray = propertyValue.Length;
                }

                //Valida a condição da questão
                if ( tamanhoArray == 0 && PesoValue.ToString() == "0")  
                {  
                    return new ValidationResult("Sem Filhos e Tamanho igual a 0"); 
                }  
                else  
                {  
                    return ValidationResult.Success;  
                }  
            }  
            else  
            {  
                return new ValidationResult("" + validationContext.DisplayName + " is Obrigatório");  
            } 
        }

    }

}