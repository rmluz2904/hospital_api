namespace hospital_api.Validações;
using System.ComponentModel.DataAnnotations;
public class ValidacaoDataNascimento : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value is DateTime data)
        {
            if (data > DateTime.Today)
            {
                ErrorMessage = "A data de nascimento deve ser anterior à data de hoje.";
                return false;
            }

            if (data.Year < 1900)
            {
                ErrorMessage = "O ano de nascimento deve ser igual ou superior a 1900.";
                return false;
            }

            return true;
        }

        ErrorMessage = "Data de nascimento inválida ou em formato incorreto (AAAA-MM-DD).";
        return false;
    }

}

