using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        private int real, imaginary;
        public ComplexNumber()
        {
        }
        public ComplexNumber(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public void SetImaginary(int imaginary) {
            this.imaginary = imaginary;
        }

        public void SetReal(int real)
        {
            this.real = real;
        }

        public string ToString() {
            string result = "";
            result = "(" + this.real + "," + this.imaginary + ")";
            return result;
        }
        public double GetMagnitude()
        {
            double result = Math.Sqrt((real * this.real) + (this.imaginary* this.imaginary));
            return result;
        }

        public ComplexNumber Add(ComplexNumber b)
        {
            //ComplexNumber s = new ComplexNumber();
            this.real = b.real + this.real;
            this.imaginary = b.imaginary + this.imaginary;
            //Console.WriteLine(s.real);
            //Console.WriteLine(s.imaginary);
            return this;
        }


    }
}
