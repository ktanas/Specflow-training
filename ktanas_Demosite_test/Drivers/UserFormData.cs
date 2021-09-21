using System;
using System.Collections.Generic;
using System.Text;

namespace ktanas_DemositeTest
{
    public class UserFormData
    {
        private string title;
        private string initial;
        private string firstName;
        private string middleName;
        private string gender;
        private bool englishLanguageIsKnown;
        private bool hindiLanguageIsKnown;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Initial
        {
            get
            {
                return initial;
            }
            set
            {
                initial = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public bool EnglishLanguageIsKnown
        {
            get
            {
                return englishLanguageIsKnown;
            }
            set
            {
                englishLanguageIsKnown = value;
            }
        }
        public bool HindiLanguageIsKnown
        {
            get
            {
                return hindiLanguageIsKnown;
            }
            set
            {
                hindiLanguageIsKnown = value;
            }
        }
    }
}
