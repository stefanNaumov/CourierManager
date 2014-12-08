using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManager
{
    public static class ValidatorIDNumber
    {
        public static bool ValidatePersonalIDNumber(string personalIDNumber)
        {
                if (personalIDNumber.Length != 10)
                {
                    throw new InvalidIDNumberException("Invalid ID number", personalIDNumber);
                }
                foreach (char digit in personalIDNumber)
                {
                    if (!Char.IsDigit(digit))
                    {
                        throw new InvalidIDNumberException("Invalid ID number", personalIDNumber);
                    }
                }
                int month = int.Parse(personalIDNumber.Substring(2, 2));
                int year = 0;
                if (month < 13)
                {
                    year = int.Parse("19" + personalIDNumber.Substring(0, 2));
                }
                else if (month < 33)
                {
                    month -= 20;
                    year = int.Parse("18" + personalIDNumber.Substring(0, 2));
                }
                else
                {
                    month -= 40;
                    year = int.Parse("20" + personalIDNumber.Substring(0, 2));
                }
                int day = int.Parse(personalIDNumber.Substring(4, 2));
                DateTime dateOfBirth = new DateTime();
                if (!DateTime.TryParse(String.Format("{0}/{1}/{2}", day, month, year), out dateOfBirth))
                {
                    throw new InvalidIDNumberException("Invalid ID number", personalIDNumber);
                }
                int[] weights = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
                int totalControlSum = 0;
                for (int i = 0; i < 9; i++)
                {
                    totalControlSum += weights[i] * (personalIDNumber[i] - '0');
                }
                int controlDigit = 0;
                int reminder = totalControlSum % 11;
                if (reminder < 10)
                {
                    controlDigit = reminder;
                }
                int lastDigitFromIDNumber = int.Parse(personalIDNumber.Substring(9));
                if (lastDigitFromIDNumber != controlDigit)
                {
                    throw new InvalidIDNumberException("Invalid ID number", personalIDNumber);
                }
                return true;
        }

        public static bool ValidateCompanyIDNumber(string companyIDNumber)
        {
                if (companyIDNumber.Length != 9 && companyIDNumber.Length != 13)
                {
                    throw new InvalidIDNumberException("Invalid ID number", companyIDNumber);
                }
                int checkSum1 = 0;
                int checkSum2 = 0;
                for (int i = 0; i < 8; i++)
                {
                    char currentDigit = companyIDNumber[i];
                    if (!Char.IsDigit(currentDigit))
                    {
                        throw new InvalidIDNumberException("Invalid ID number", companyIDNumber);
                    }
                    checkSum1 += (currentDigit - 48) * (i + 1);
                    checkSum2 += (currentDigit - 48) * (i + 3);
                }
                int controlDigit = checkSum1 % 11;
                if (controlDigit == 10)
                    controlDigit = checkSum2 % 11;
                if (controlDigit == 10)
                    controlDigit = 0;
                if (Convert.ToInt16(companyIDNumber[8]) != controlDigit + 48)
                {
                    throw new InvalidIDNumberException("Invalid ID number", companyIDNumber);
                }
                if (companyIDNumber.Length == 13)
                {
                    int[] weight1 = { 2, 7, 3, 5 };
                    int[] weight2 = { 4, 9, 5, 7 };
                    checkSum1 = 0;
                    checkSum2 = 0;
                    for (int i = 8; i < 13; i++)
                    {
                        char currentDigit = companyIDNumber[i];
                        if (!Char.IsDigit(currentDigit))
                        {
                            throw new InvalidIDNumberException("Invalid ID number", companyIDNumber);
                        }
                        checkSum1 += (currentDigit - 48) * weight1[i - 8];
                        checkSum2 += (currentDigit - 48) * weight2[i - 8];
                    }
                    if (controlDigit + 48 != Convert.ToInt16(companyIDNumber[12]))
                    {
                        throw new InvalidIDNumberException("Invalid ID number", companyIDNumber);
                    }
                }
                return true;
        }
    }
}
