using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictatorsInformationApi
{
    public class DictatorModel
    {
        #region fields
        private string _id;
        private string _firstName;
        private string _lastName;
        private string _birth;
        private string _death;
        private string _description;
        #endregion

        #region Constructor

        public DictatorModel()
        {
            Id = Guid.NewGuid().ToString();
        }
        public DictatorModel(string firstName, string lastname, string birth, string death, string description)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastname;
            Birth = birth;
            Death = death;
            Description = description;
        }
        #endregion

        #region Properties

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        [MaxLength(80)]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        [Required]
        [MaxLength(80)]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Birth
        {
            get { return _birth; }
            set { _birth = value; }
        }
        public string Death
        {
            get { return _death; }
            set { _death = value; }
        }
        [Required]
        [MaxLength(80)]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        #endregion




    }
}
