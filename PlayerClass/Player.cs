using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClass
{
    public class Player
    {
        private string id;
        private string name;
        private string dob;
        private string playerHeight;
        private string weight;
        private string birthPlace;
        private string signedTeam;

        public string Id
        {
            get { return id; }
            //set { id = value; }
        }
        public string PlayerName
        {
            get { return name; }
            //set { name = value; }
        }
        public string Dob
        {
            get { return dob; }
            //set { dob = value; }
        }
        public string Height
        {
            get { return playerHeight; }
            //set { height = value; }
        }
        public string Weight
        {
            get { return weight; }
           //set { weight = value; }
        }
        public string BirthPlace
        {
            get { return birthPlace; }
            //set { birthPlace = value; }
        }
        public string SignedTeam
        {
            get { return signedTeam; }
            set { signedTeam = value; }
        }

        public Player(string myId, string myName, string myDob, string myHeight, string myWeight, string myBirthPlace, string mySignedTeam)
        {
            id = myId;
            name = myName;
            dob = myDob;
            playerHeight = myHeight;
            weight = myWeight;
            birthPlace = myBirthPlace;
            signedTeam = mySignedTeam;
        }

    }
}
