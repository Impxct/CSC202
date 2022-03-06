using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase_Alpha
{
    public partial class FormMain : Form

    // runs when form loads 1 time
    {
        public FormMain()
        {
            InitializeComponent();
            // sets up name of room that is started in.
            textBoxAreaName.Text = "General Purpose Room";
            // sets up the description of the room started in.
            textBoxAreaDescription.Text = "You are in the General Purpose Room. This room has a little of everything in it.";
        }
        /// <summary>
        /// The code below handles the event of user clicking North
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void labelDesription_Click(object sender, EventArgs e)
        {
            //creates our obejct from classes.
            //syntax for this is : Class name, Object Name.
            ClassArea objectGeneralPurposeRoom = new ClassArea();
            ClassArea objectLandingPad = new ClassArea();
            ClassArea objectWestWingCommsRoom = new ClassArea();
            ClassArea objectSouthCorridors = new ClassArea();
            ClassArea objectEastLivingQuarters = new ClassArea();
            //set Properties for all objects..
            objectGeneralPurposeRoom.AreaDescription = "You are in the General Purpose Room. This room has a little of everything in it.";
            objectGeneralPurposeRoom.AreaName = "General Purpose Room";
            objectLandingPad.AreaDescription = "Eagle transporter on the North Landing Pad.";
            objectLandingPad.AreaName = "North Landing Pad";
            objectWestWingCommsRoom.AreaDescription = "This is the communications room.";
            objectWestWingCommsRoom.AreaName = "West Wing Comms Room.";
            objectSouthCorridors.AreaDescription = "Here are the main Corridors. Decide where you will go.";
            objectSouthCorridors.AreaName = "Soutern Corridors";
            objectEastLivingQuarters.AreaDescription = "This is your room! Get as comforatable as you'd like.";
            objectEastLivingQuarters.AreaName = "Eastern Living Quarters.";
        }

        private void buttonNorth_Click(object sender, EventArgs e)
        {
            //this event is raised when the user clicks north button from the gpr
            //changes area name
            textBoxAreaName.Text = "North Landing Pad";
            //changes area description
            textBoxAreaDescription.Text = "Eagle transporter on the North Landing Pad.";
            //changes the area background
            this.BackgroundImage = Properties.Resources.LandingPad;
        }

        private void buttonWest_Click(object sender, EventArgs e)
        {
            //this event is raised when the user clicks West button from the gpr
            //changes area name
            textBoxAreaName.Text = "West Wing Comms Room.";
            //changes area description
            textBoxAreaDescription.Text = "This is the communications room.";
            //changes the area background
            this.BackgroundImage = Properties.Resources.CommunicationRoom;
        }

        private void buttonSouth_Click(object sender, EventArgs e)
        {
            //this event is raised when the user clicks South button from the gpr 
            //changes area name
            textBoxAreaName.Text = "Soutern Corridors";
            //changes area description
            textBoxAreaDescription.Text = "Here are the main Corridors. Decide where you will go.";
            //changes the area background
            this.BackgroundImage = Properties.Resources.SouthCorridors_;
        }

        private void buttonEast_Click(object sender, EventArgs e)
        {
            //this event is raised when the user clicks east button from the gpr
            //changes area name
            textBoxAreaName.Text = "Eastern Living Quarters.";
            //changes area description
            textBoxAreaDescription.Text = "This is your room! Get as comforatable as you'd like.";
            //changes the area background
            this.BackgroundImage = Properties.Resources.usersroom;
        }
    }
}