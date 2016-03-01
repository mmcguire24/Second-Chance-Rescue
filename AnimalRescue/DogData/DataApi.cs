﻿using Android.App;
using Android.Widget;
using Android.OS;
using System.Net.Http;
using System;
using HtmlAgilityPack;
using Scraper;
using DogData;
using System.Collections.Generic;
using Marcus.ListView.CustomListAdapter;
using System.Threading;
using Android.Graphics;
using SecondChanceResuce;
using AnimatedLoadingViews;
using AnimalRescue;

namespace DogData
{
	public class DataApi : Activity
	{

		public DataApi ( Activity inActivity, string animal)
		{
			this.bactivity = inActivity;
			animalType = animal;
		}

		public Activity bactivity;
		public string animalType;
		private Petstuff pet;

		public List <Dog> dogList = new List<Dog>();

		public List<Dog> getData(){
			
			pet = new Petstuff (animalType);
			Dog doggy = new Dog();
			//doggy.FillDog(pet.dogData);
			List <Dog> dogList = new List<Dog>();
			for(int i = 0; i < 30/*pet.picUrls.Count*/; i++)
			{
				Dog tempDoggy = new Dog(pet.names[i],pet.breeds[i],pet.picUrls[i]);
				dogList.Add(tempDoggy);
			}

			/*this.bactivity.SetContentView (Resource.Layout.Main);
			ListView mainList = (ListView)this.bactivity.FindViewById (Resource.Id.mainlistview);
			mainList.Adapter = new CustomListAdapter (this.bactivity, dogList);
			mainList.SetBackgroundColor (Color.AliceBlue);
			AnimatedCircleLoadingView loading;
			loading = this.bactivity.FindViewById<AnimatedCircleLoadingView> (Resource.Id.circle_loading_view);
			TextView mainText = (TextView)this.bactivity.FindViewById (Resource.Id.mainText);
			mainText.Text = dogList [0].Name;
			loading.Visibility = Android.Views.ViewStates.Gone;
			mainList.Visibility = Android.Views.ViewStates.Gone;*/

			RunOnUiThread (() => DisplayData(dogList));
			return dogList;
		}

		public void DisplayData(List<Dog> UidogList)
		{
			//this.bactivity.SetContentView (Resource.Layout.Main);
			//return;
			ListView mainList = (ListView)this.bactivity.FindViewById (Resource.Id.mainlistview);
			mainList.Adapter = new CustomListAdapter (this.bactivity, UidogList);
			mainList.SetBackgroundColor (Color.BurlyWood);
			AnimatedCircleLoadingView loading;

			loading = this.bactivity.FindViewById<AnimatedCircleLoadingView> (Resource.Id.circle_loading_view);
			TextView mainText = (TextView)this.bactivity.FindViewById (Resource.Id.mainText);
			mainText.Text = UidogList [0].Name;
			loading.Visibility = Android.Views.ViewStates.Gone;
			//mainList.Visibility = Android.Views.ViewStates.Gone;


		}
	}
}

