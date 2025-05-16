using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace hospital_api.Validações
{
    public class ValidacaoNIF : ValidationAttribute        //Cria excepções do NIF (tem de ter 9 numeros e começar por um número de 1 a 8
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                ErrorMessage = "O NIF é obrigatório.";
                return false;
            }

            var nifString = value.ToString();

            // Verifica se tem exatamente 9 dígitos
            if (!Regex.IsMatch(nifString, @"^\d{9}$"))
            {
                ErrorMessage = "O NIF deve conter 9 dígitos numéricos.";
                return false;
            }

            // Valida prefixo
            char primeiroDigito = nifString[0];
            if ("125678".IndexOf(primeiroDigito) == -1)
            {
                ErrorMessage = "O NIF deve começar por 1, 2, 5, 6, 7 ou 8.";
                return false;
            }

            return true;
        }
    }
}

