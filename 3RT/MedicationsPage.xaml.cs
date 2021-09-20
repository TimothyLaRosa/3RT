using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _3RT
{

public partial class MedicationsPage : ContentPage
    {
        public MedicationsPage()
        {
            InitializeComponent();
        }


        List<string> userMedications = new List<string>();
        List<string> userAllergies = new List<string>();
        List<int> userDosages = new List<int>();



        async void medListViewButton(object sender, EventArgs args)
        {
                await Navigation.PushAsync(new MedicationsListPage());
        }

        async void medListSaveButton(object sender, EventArgs args)
        {


            string user = myName.ToString();
            string allergies = myAllergies.ToString();
            string myAsNeeded = myMedicationAsNeededName.ToString() + ", " + myMedicationAsNeededAppearance.ToString() + ", " + myMedicationsAsNeededSymptoms.ToString();
            string myMorning = myMedicationMorningName.ToString() + ", " + myMedicationMorningAppearance.ToString() + ", " + myMedicationsMorningSymptoms.ToString();
            string myAfternoon = myMedicationAfternoonName.ToString() + ", " + myMedicationAfternoonAppearance.ToString() + ", " + myMedicationsAfternoonSymptoms.ToString();
            string myEvening = myMedicationEveningName.ToString() + ", " + myMedicationEveningAppearance.ToString() + ", " + myMedicationsEveningSymptoms.ToString();




            userAllergies.Add(allergies);
            userMedications.Add(myAsNeeded);
            userMedications.Add(myMorning);
            userMedications.Add(myAfternoon);
            userMedications.Add(myEvening);



            await DisplayAlert("Success", "Medications Saved", "OK");


        }
    }

}