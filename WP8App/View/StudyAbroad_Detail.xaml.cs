// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   PageCS.tt
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Newtonsoft.Json;
using WPAppStudio;
using WPAppStudio.Entities;
using WPAppStudio.Helpers;
using WPAppStudio.Ioc;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;
using WPAppStudio.Resources;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for StudyAbroad_Detail.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class StudyAbroad_Detail : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for StudyAbroad_Detail and all its components.
        /// </summary>
        public StudyAbroad_Detail()
        {
            InitializeComponent();        
			if (Resources.Contains("PanoramaStudyAbroad_Detail0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["PanoramaStudyAbroad_Detail0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramaStudyAbroad_Detail_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramaStudyAbroad_Detail(PanoramaStudyAbroad_Detail.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramaStudyAbroad_Detail(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
		    else if(ApplicationBar != null)
		        ApplicationBar.IsVisible = false;
        }
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string currentId;
			
            if (NavigationContext.QueryString.TryGetValue("currentID", out currentId))
            {
				var dataSource = new Container().Resolve<IStudyAbroadDS>();
				AddHomeAppBarButton();
				var pinnedItem  = (await dataSource.GetData()).FirstOrDefault(x => IsPinnedItem(x.Title.ToString(), currentId));
				if(pinnedItem==null)
					MessageBox.Show(AppResources.PinError);
				((StudyAbroad_DetailViewModel)DataContext).CurrentRssSearchResult = pinnedItem;				
			}

            MyLiveTileHelper.UpdateLiveTile(((StudyAbroad_DetailViewModel)DataContext).CurrentRssSearchResult);
		}

        private static bool IsPinnedItem(string itemId, string currentId)
        {
            itemId = itemId.Trim();
            currentId = HttpUtility.UrlDecode(currentId.Trim());
            return itemId.Equals(currentId, StringComparison.InvariantCultureIgnoreCase);
        }
		
        private void AddHomeAppBarButton()
        {
            if (ApplicationBar.Buttons.Count >= 4 ||
                ApplicationBar.Buttons.Cast<ApplicationBarIconButton>().Any(button => button.Text == "Home")) 
                return;
						
			var homeIcon = new ApplicationBarIconButton() {IconUri = new Uri("/Images/Icons/Light/Home.png", UriKind.Relative), IsEnabled = true, Text = "Home"};
            homeIcon.Click += delegate 
			{ 
				new Container().Resolve<INavigationService>().NavigateTo<IStudyAbroad_NewsViewModel>(); 
				while (NavigationService.RemoveBackEntry() != null);
			};
            ApplicationBar.Buttons.Add(homeIcon);
        }
    }
}
