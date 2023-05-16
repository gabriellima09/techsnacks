using System.Text.RegularExpressions;
using TechSnacks.Domain.Core;

namespace TechSnacks.Domain.ValueObjects
{
    public class Phone : ValueObject
    {
        public Phone(string number)
        {
            Number = number ?? throw new ArgumentNullException(nameof(number));
        }
     
        public string Number { get; private set; }

        public bool IsValid => Validate();

        private bool Validate()
        {
            var regexExp = "^(1[1-9]|[4689][0-9]|2[12478]|3([1-5]|[7-8])|5([13-5])|7[193-7])9[0-9]{8}$";

            return Regex.IsMatch(Number, regexExp);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Number;
        }
    }
}
