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
        // base price (without discounts) for customer
        const float BASEPRICE = 16.00f;

        String name = null;
        int age = 0;
        bool isStudent = false;
        bool isConscript = false;
        bool isMTKmember = false;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"> customer's name </param>
        public Customer(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// set customer's age
        /// </summary>
        /// <param name="age"> age in years </param>
        public void setAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// set customer's student status
        /// </summary>
        /// <param name="isStudent"> true, if customer is a student </param>
        public void setStudent(bool isStudent)
        {
            this.isStudent = isStudent;
        }

        /// <summary>
        /// set customer's conscript status
        /// </summary>
        /// <param name="isConscript"> true, if customer is a conscript </param>
        public void setConscript(bool isConscript)
        {
            this.isConscript = isConscript;
        }

        /// <summary>
        /// set customer's member of MTK status
        /// </summary>
        /// <param name="isMTKmember"> true, if customer is a member of MTK </param>
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
                price = 0.00f; // free ticket for children under 7 years old
            }
            else if (isMTKmember && isStudent)
            {
                price *= 0.40f; // 15% + 45% discount if customer is student and member of MTK
            }
            else if (age >= 65)
            {
                price *= 0.50f; // 50% discount for pensioners
            }
            else if (age <= 15)
            {
                price *= 0.50f; // 50% discount for young people (age between 7 and 15 (inclusive))
            }
            else if (isConscript)
            {
                price *= 0.50f; // 50% discount for conscripts
            }
            else if (isStudent)
            {
                price *= 0.55f; // 45% discount for students
            }
            else if (isMTKmember)
            {
                price *= 0.85f; // 15% discount for members of MTK
            }
            else
            {
                // no discount
            }

            return price;
        }

    }
}
