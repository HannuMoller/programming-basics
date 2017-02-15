using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
    /// <summary>
    /// Customer data and logic for calculating price discounts
    /// </summary>
    class Customer
    {
        /// <summary>
        /// base price (without discounts) for customer
        /// </summary>
        const float BASEPRICE = 16.00f;

        String name = null;
        int age = 0;
        bool isStudent = false;
        bool isConscript = false;
        bool isMTKmember = false;


        public Customer(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setStudent(bool isStudent)
        {
            this.isStudent = isStudent;
        }

        public void setConscript(bool isConscript)
        {
            this.isConscript = isConscript;
        }

        public void setMTKmember(bool isMTKmember)
        {
            this.isMTKmember = isMTKmember;
        }

        /// <summary>
        /// calculate actual price for customer
        /// </summary>
        /// <returns> actual price with discounts </returns>
        public float getPrice()
        {
            float price = BASEPRICE;

            if (age < 7)
            {
                price = 0.00f; // free
            }
            else if (isMTKmember && isStudent)
            {
                price *= 0.40f; // 15% + 45% discount
            }
            else if (age >= 65)
            {
                price *= 0.50f; // 50% discount
            }
            else if (age <= 15)
            {
                price *= 0.50f; // 50% discount
            }
            else if (isConscript)
            {
                price *= 0.50f; // 50% discount
            }
            else if (isStudent)
            {
                price *= 0.55f; // 45% discount
            }
            else if (isMTKmember)
            {
                price *= 0.85f; // 15% discount
            }

            return price;
        }

    }
}
