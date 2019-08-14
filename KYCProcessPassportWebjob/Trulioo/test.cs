using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYCProcessPassportWebjob.Trulioo
{
    class test
    {

        public class Rootobject
        {
            public ApplicationJson applicationjson { get; set; }
        }

        public class ApplicationJson
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties properties { get; set; }
        }

        public class Properties
        {
            public Personinfo PersonInfo { get; set; }
            public Location Location { get; set; }
            public Communication Communication { get; set; }
            public Driverlicence DriverLicence { get; set; }
            public Nationalids NationalIds { get; set; }
            public Passport Passport { get; set; }
            public Document Document { get; set; }
            public Countryspecific CountrySpecific { get; set; }
        }

        public class Personinfo
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties1 properties { get; set; }
            public string[] required { get; set; }
        }

        public class Properties1
        {
            public Firstgivenname FirstGivenName { get; set; }
            public Middlename MiddleName { get; set; }
            public Firstsurname FirstSurName { get; set; }
            public Dayofbirth DayOfBirth { get; set; }
            public Monthofbirth MonthOfBirth { get; set; }
            public Yearofbirth YearOfBirth { get; set; }
            public Gender Gender { get; set; }
        }

        public class Firstgivenname
        {
            public string type { get; set; }
        }

        public class Middlename
        {
            public string type { get; set; }
        }

        public class Firstsurname
        {
            public string type { get; set; }
        }

        public class Dayofbirth
        {
            public string type { get; set; }
        }

        public class Monthofbirth
        {
            public string type { get; set; }
        }

        public class Yearofbirth
        {
            public string type { get; set; }
        }

        public class Gender
        {
            public string type { get; set; }
        }

        public class Location
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties2 properties { get; set; }
            public string[] required { get; set; }
        }

        public class Properties2
        {
            public Buildingnumber BuildingNumber { get; set; }
            public Unitnumber UnitNumber { get; set; }
            public Streetname StreetName { get; set; }
            public Streettype StreetType { get; set; }
            public Suburb Suburb { get; set; }
            public Stateprovincecode StateProvinceCode { get; set; }
            public Postalcode PostalCode { get; set; }
        }

        public class Buildingnumber
        {
            public string type { get; set; }
        }

        public class Unitnumber
        {
            public string type { get; set; }
        }

        public class Streetname
        {
            public string type { get; set; }
        }

        public class Streettype
        {
            public string type { get; set; }
        }

        public class Suburb
        {
            public string type { get; set; }
        }

        public class Stateprovincecode
        {
            public string type { get; set; }
        }

        public class Postalcode
        {
            public string type { get; set; }
        }

        public class Communication
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties3 properties { get; set; }
            public object[] required { get; set; }
        }

        public class Properties3
        {
            public Mobilenumber MobileNumber { get; set; }
            public Telephone Telephone { get; set; }
            public Emailaddress EmailAddress { get; set; }
        }

        public class Mobilenumber
        {
            public string type { get; set; }
        }

        public class Telephone
        {
            public string type { get; set; }
        }

        public class Emailaddress
        {
            public string type { get; set; }
        }

        public class Driverlicence
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties4 properties { get; set; }
            public string[] required { get; set; }
        }

        public class Properties4
        {
            public Number Number { get; set; }
        }

        public class Number
        {
            public string type { get; set; }
        }

        public class Nationalids
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties5 properties { get; set; }
            public string[] required { get; set; }
        }

        public class Properties5
        {
            public Number1 Number { get; set; }
            public Type Type { get; set; }
        }

        public class Number1
        {
            public string type { get; set; }
        }

        public class Type
        {
            public string type { get; set; }
            public string value { get; set; }
        }

        public class Passport
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties6 properties { get; set; }
            public string[] required { get; set; }
        }

        public class Properties6
        {
            public Number2 Number { get; set; }
        }

        public class Number2
        {
            public string type { get; set; }
        }

        public class Document
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties7 properties { get; set; }
            public string[] required { get; set; }
        }

        public class Properties7
        {
            public Documentfrontimage DocumentFrontImage { get; set; }
            public Documentbackimage DocumentBackImage { get; set; }
            public Documenttype DocumentType { get; set; }
        }

        public class Documentfrontimage
        {
            public string type { get; set; }
        }

        public class Documentbackimage
        {
            public string type { get; set; }
        }

        public class Documenttype
        {
            public string type { get; set; }
        }

        public class Countryspecific
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties8 properties { get; set; }
        }

        public class Properties8
        {
            public AU AU { get; set; }
        }

        public class AU
        {
            public string title { get; set; }
            public string type { get; set; }
            public Properties9 properties { get; set; }
            public string[] required { get; set; }
        }

        public class Properties9
        {
            public Auimmicardnumber AuImmiCardNumber { get; set; }
            public Citizenshipacquisitionday CitizenshipAcquisitionDay { get; set; }
            public Citizenshipacquisitionmonth CitizenshipAcquisitionMonth { get; set; }
            public Citizenshipacquisitionyear CitizenshipAcquisitionYear { get; set; }
            public Countryofbirth CountryOfBirth { get; set; }
            public Driverlicencedayofexpiry DriverLicenceDayOfExpiry { get; set; }
            public Driverlicencemonthofexpiry DriverLicenceMonthOfExpiry { get; set; }
            public Driverlicencestate DriverLicenceState { get; set; }
            public Driverlicenceyearofexpiry DriverLicenceYearOfExpiry { get; set; }
            public Familynameatbirth FamilyNameAtBirth { get; set; }
            public Medicarecolor MedicareColor { get; set; }
            public Medicaremonthofexpiry MedicareMonthOfExpiry { get; set; }
            public Medicarereference MedicareReference { get; set; }
            public Medicareyearofexpiry MedicareYearOfExpiry { get; set; }
            public Passportcountry PassportCountry { get; set; }
            public Placeofbirth PlaceOfBirth { get; set; }
            public Registrationnumber RegistrationNumber { get; set; }
            public Registrationstate RegistrationState { get; set; }
            public Stocknumber StockNumber { get; set; }
            public Certificatenumber CertificateNumber { get; set; }
            public Dayofprint DayOfPrint { get; set; }
            public Familynameatcitizenship FamilyNameAtCitizenship { get; set; }
            public Medicaredayofexpiry MedicareDayOfExpiry { get; set; }
            public Monthofprint MonthOfPrint { get; set; }
            public Rtacardnumber RTACardNumber { get; set; }
            public Registrationyear RegistrationYear { get; set; }
            public Yearofprint YearOfPrint { get; set; }
        }

        public class Auimmicardnumber
        {
            public string type { get; set; }
        }

        public class Citizenshipacquisitionday
        {
            public string type { get; set; }
        }

        public class Citizenshipacquisitionmonth
        {
            public string type { get; set; }
        }

        public class Citizenshipacquisitionyear
        {
            public string type { get; set; }
        }

        public class Countryofbirth
        {
            public string type { get; set; }
        }

        public class Driverlicencedayofexpiry
        {
            public string type { get; set; }
        }

        public class Driverlicencemonthofexpiry
        {
            public string type { get; set; }
        }

        public class Driverlicencestate
        {
            public string type { get; set; }
        }

        public class Driverlicenceyearofexpiry
        {
            public string type { get; set; }
        }

        public class Familynameatbirth
        {
            public string type { get; set; }
        }

        public class Medicarecolor
        {
            public string type { get; set; }
        }

        public class Medicaremonthofexpiry
        {
            public string type { get; set; }
        }

        public class Medicarereference
        {
            public string type { get; set; }
        }

        public class Medicareyearofexpiry
        {
            public string type { get; set; }
        }

        public class Passportcountry
        {
            public string type { get; set; }
        }

        public class Placeofbirth
        {
            public string type { get; set; }
        }

        public class Registrationnumber
        {
            public string type { get; set; }
        }

        public class Registrationstate
        {
            public string type { get; set; }
        }

        public class Stocknumber
        {
            public string type { get; set; }
        }

        public class Certificatenumber
        {
            public string type { get; set; }
        }

        public class Dayofprint
        {
            public string type { get; set; }
        }

        public class Familynameatcitizenship
        {
            public string type { get; set; }
        }

        public class Medicaredayofexpiry
        {
            public string type { get; set; }
        }

        public class Monthofprint
        {
            public string type { get; set; }
        }

        public class Rtacardnumber
        {
            public string type { get; set; }
        }

        public class Registrationyear
        {
            public string type { get; set; }
        }

        public class Yearofprint
        {
            public string type { get; set; }
        }

    }
}
