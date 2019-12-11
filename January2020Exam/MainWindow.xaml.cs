using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace January2020Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> AllPlayers = new List<Player>();
        List<Player> selPlayers = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e) //create activity objects list and sort it according to date
        {

            CreatePlayers();
           
            lstBxAllPlayers.ItemsSource = AllPlayers;           //assign AllPlayers list as the itemsource 
            lstBxSelectedPlayers.ItemsSource = selPlayers;
        }



        private List<Player> CreatePlayers()           //method to create and return the list of players
        {


            Player p1 = new Player()
            //test listbox by adding player
            {
                FirstName = "Sophie", Surname = "O'Neill", DateOfBirth = new DateTime(1999, 06, 02),
            };


            /*
            will need to generate 2 random numbers and then select from array of firstnames and surnames.

            also will need to generate a random date of birth withing limits to give age between 20-30

            string[] firstNames = {
                "Adam", "Amelia", "Ava", "Chloe", "Conor", "Daniel", "Emily",
                "Emma", "Grace", "Hannah", "Harry", "Jack", "James",
                "Lucy", "Luke", "Mia", "Michael", "Noah", "Sean", "Sophie"};


            string[] lastNames = {
                "Brennan", "Byrne", "Daly", "Doyle", "Dunne", "Fitzgerald", "Kavanagh",
                "Kelly", "Lynch", "McCarthy", "McDonagh", "Murphy", "Nolan", "O'Brien",
                "O'Connor", "O'Neill", "O'Reilly", "O'Sullivan", "Ryan", "Walsh"
            };

            */
            AllPlayers.Add(p1);

            return AllPlayers;
        }

        private void lstBxAllPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)  //all players list block
        {
            //allows for an object to be selected from the list
            Player selected = lstBxAllPlayers.SelectedItem as Player;
            
        }
        private void lstBxSelectedPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e) //selected players list block
        {
            //allows for an object to be selected from the list
            Player selected = lstBxSelectedPlayers.SelectedItem as Player;
            
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)   //button to move activites to the right hand listbox   
        {
            //will add the object selected from AllPlayers to selplayers list
            Player selectedPlayer = lstBxAllPlayers.SelectedItem as Player;

            if (selectedPlayer != null)    //checks if a player has been selected and then adds/removes from relevant lists
            {
                    AllPlayers.Remove(selectedPlayer);
                    selPlayers.Add(selectedPlayer);
            }
            if (selectedPlayer == null)
                txtBlkDescription.Text = "No player has been selected";
        }

       

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            Player selectedPlayer = lstBxAllPlayers.SelectedItem as Player;

            if (selectedPlayer != null)    //checks if a player has been selected and then adds/removes from relevant lists
            {
                selPlayers.Remove(selectedPlayer);
                AllPlayers.Add(selectedPlayer);
            }
            if (selectedPlayer == null)
                txtBlkDescription.Text = "No player has been selected";
        }
    }
}
