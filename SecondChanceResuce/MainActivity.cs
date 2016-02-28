using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using System.Net.Http;
using System;
using HtmlAgilityPack;
using Scraper;
using DogData;
using System.Collections.Generic;
using Marcus.ListView.CustomListAdapter;
using SecondChanceResuce;

namespace SecondChanceRescue
{
	[Activity (Label = "Second Chance Rescue", MainLauncher = true, Icon = "@mipmap/sclogo")]
	public class MainActivity : Activity
	{
		ListView LV = null;


		protected override void OnCreate (Bundle savedInstanceState)
		{
			
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			LV = FindViewById<ListView> (Resource.Id.mainlistview);
			LV.SetBackgroundColor (Color.Wheat);
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				TextView MainTextView = FindViewById<TextView> (Resource.Id.mainTextView);
			
				Petstuff pet = new Petstuff("dog");
				Dog doggy = new Dog();
				//doggy.FillDog(pet.dogData);
				List <Dog> dogList = new List<Dog>();
				for(int i = 0; i < pet.picUrls.Count; i++)
				{
					Dog tempDoggy = new Dog(pet.names[i],pet.breeds[i],pet.picUrls[i]);
					dogList.Add(tempDoggy);
				}


				ListView mainList = (ListView)FindViewById (Resource.Id.mainlistview);
				mainList.Adapter = new CustomListAdapter (this, dogList);


			};

			Button catbutton = FindViewById<Button> (Resource.Id.catButton);

			catbutton.Click += delegate {
				TextView MainTextView = FindViewById<TextView> (Resource.Id.mainTextView);

				Petstuff pet = new Petstuff("cat");
				Dog doggy = new Dog();
				//doggy.FillDog(pet.dogData);
				List <Dog> dogList = new List<Dog>();
				for(int i = 0; i < pet.picUrls.Count; i++)
				{
					Dog tempDoggy = new Dog(pet.names[i],pet.breeds[i],pet.picUrls[i]);
					dogList.Add(tempDoggy);
				}


				ListView mainList = (ListView)FindViewById (Resource.Id.mainlistview);
				mainList.Adapter = new CustomListAdapter (this, dogList);


			};
		}
	}
}


