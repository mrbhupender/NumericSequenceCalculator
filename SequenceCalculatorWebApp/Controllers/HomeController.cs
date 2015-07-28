using SequenceCalculatorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SequenceCalculatorWebApp.Controllers
{
    public class HomeController : Controller
    {
        SequencesViewModel allSequences = new SequencesViewModel();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(int? inputNumber)
        {
            SequencesViewModel sequencesViewModel = new SequencesViewModel();
            if (!inputNumber.HasValue) return View();
            return View(GetAllSequences(Convert.ToInt32(inputNumber)));
        }
        private SequencesViewModel GetAllSequences(int inputNumber)
        {
            allSequences.InputNumber = inputNumber;
            allSequences.AllNumbers = string.Join<int>(",", GetAllNumbers(inputNumber));
            allSequences.EvenNumbers = string.Join<int>(",", GetEvenNumbers(inputNumber));
            allSequences.OddNumbers = string.Join<int>(",", GetOddNumbers(inputNumber));
            allSequences.CustomSequence = string.Join<string>(",", GetCustomSequence(inputNumber));
            try
            {
                allSequences.FibonacciNumbers = string.Join<long>(",", GetAllFibonacciNumbers(inputNumber));
            }
            catch(ArgumentOutOfRangeException ex)
            {
                allSequences.FibonacciNumbers = ex.Message;
            }
            
            allSequences.AreSequencesGenerated = true;
            return allSequences;
        }

        private List<long> GetAllFibonacciNumbers(int inputNumber)
        {
            var fibonacciNumbers = new List<long>();
            var allNumbers = GetAllNumbers(inputNumber);
            foreach(int i in allNumbers)
            {
                fibonacciNumbers.Add(FibonacciNumber(Convert.ToInt64(i)));
            }
            return fibonacciNumbers;
        }

        private List<string> GetCustomSequence(int inputNumber)
        {
            var customSequence = new List<string>(); 
            var allNumbers = GetAllNumbers(inputNumber);
            foreach(int i in allNumbers)
            {
                if (IsDivisble(i, 3) && IsDivisble(i, 5))
                    customSequence.Add("Z");
                else if (IsDivisble(i, 3))
                    customSequence.Add("C");
                else if (IsDivisble(i, 5))
                    customSequence.Add("E");
                else
                    customSequence.Add(i.ToString());
            }
            return customSequence;
        }

        private List<int> GetOddNumbers(int inputNumber)
        {
            var oddNumbers = new List<int>();
            for (int i = 0; i <= inputNumber; i++)
            {
                if (!IsDivisble(i,2))
                    oddNumbers.Add(i);
            }
            return oddNumbers;
        }

        private List<int> GetEvenNumbers(int inputNumber)
        {
            var evenNumbers = new List<int>();
            for (int i = 0; i <= inputNumber; i++)
            {
                if (IsDivisble(i,2))
                    evenNumbers.Add(i);
            }
            return evenNumbers;
        }

        private List<int> GetAllNumbers(int inputNumber)
        {
            var allNumbers = new List<int>();
            for (int i = 0; i <= inputNumber; i++)
            {
                allNumbers.Add(i);
            }
            return allNumbers;
        }

        public bool IsDivisble(int dividend, int divisor)
        {
            return (dividend % divisor) == 0;
        }

        private long FibonacciNumber(long n)
        {
            try
            {
                if (n > 92 || n < -92)
                    throw new ArgumentOutOfRangeException();

                if (Math.Abs(n) == 0 || Math.Abs(n) == 1)
                {
                    return Math.Abs(n);
                }

                long a = 0;
                long b = 1;
                long c = 1;

                for (int i = 1; i < Math.Abs(n); i++)
                {
                    c = b + a;
                    a = b;
                    b = c;
                }
                if (n < 0)
                {
                    return Convert.ToInt64(c * (n >= 0 ? 1 : Math.Pow(-1, Math.Abs(n) + 1)));
                }
                return c;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new ArgumentOutOfRangeException("Entered Number(>92) will cause a 64-bit integer overflow ");
            }
        }
    }
}