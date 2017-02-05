// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WPAppStudio;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Localization;
using WPAppStudio.Repositories;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.Shared;
using WPAppStudio.ViewModel.Base;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of StudyAbroad_Detail ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class StudyAbroad_DetailViewModel : BindableBase, IStudyAbroad_DetailViewModel, INavigable
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly ISpeechService _speechService;
		private readonly IShareService _shareService;
		private readonly ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="StudyAbroad_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public StudyAbroad_DetailViewModel(IDialogService dialogService, INavigationService navigationService, ISpeechService speechService, IShareService shareService, ILiveTileService liveTileService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		

		private RssSearchResult _currentRssSearchResult;

        /// <summary>
        /// CurrentRssSearchResult property.
        /// </summary>		
        public RssSearchResult CurrentRssSearchResult
        {
            get
            {
				return _currentRssSearchResult;
            }
            set
            {
                SetProperty(ref _currentRssSearchResult, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechStudyAbroad_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechStudyAbroad_DetailStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentRssSearchResult.Title + " " + CurrentRssSearchResult.Content);
        }
		

        private ICommand _textToSpeechStudyAbroad_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechStudyAbroad_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechStudyAbroad_DetailStaticControlCommand
        {
            get { return _textToSpeechStudyAbroad_DetailStaticControlCommand = _textToSpeechStudyAbroad_DetailStaticControlCommand ?? new DelegateCommand(TextToSpeechStudyAbroad_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareStudyAbroad_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareStudyAbroad_DetailStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentRssSearchResult.Title, CurrentRssSearchResult.Summary, CurrentRssSearchResult.FeedUrl);
        }
		

        private ICommand _shareStudyAbroad_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareStudyAbroad_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareStudyAbroad_DetailStaticControlCommand
        {
            get { return _shareStudyAbroad_DetailStaticControlCommand = _shareStudyAbroad_DetailStaticControlCommand ?? new DelegateCommand(ShareStudyAbroad_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartStudyAbroad_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartStudyAbroad_DetailStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(IStudyAbroad_DetailViewModel), CreateTileInfoStudyAbroad_DetailStaticControl());
        }
		

        private ICommand _pinToStartStudyAbroad_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartStudyAbroad_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartStudyAbroad_DetailStaticControlCommand
        {
            get { return _pinToStartStudyAbroad_DetailStaticControlCommand = _pinToStartStudyAbroad_DetailStaticControlCommand ?? new DelegateCommand(PinToStartStudyAbroad_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceStudyAbroad_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceStudyAbroad_DetailStaticControlCommandDelegate() 
        {
	
				_navigationService.NavigateTo(new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceStudyAbroad_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceStudyAbroad_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceStudyAbroad_DetailStaticControlCommand
        {
            get { return _goToSourceStudyAbroad_DetailStaticControlCommand = _goToSourceStudyAbroad_DetailStaticControlCommand ?? new DelegateCommand(GoToSourceStudyAbroad_DetailStaticControlCommandDelegate); }
        }
		public object NavigationContext
        {
            set
            {              
                if (!(value is RssSearchResult)) { return; }
                
                CurrentRssSearchResult = value as RssSearchResult;
            }
        }
        /// <summary>
        /// Initializes a <see cref="TileInfo" /> object for the StudyAbroad_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="TileInfo" /> object.</returns>
        public TileInfo CreateTileInfoStudyAbroad_DetailStaticControl()
        {
            var tileInfo = new TileInfo
            {
                CurrentId = CurrentRssSearchResult.Title,
                Title = CurrentRssSearchResult.Title,
                BackTitle = CurrentRssSearchResult.Title,
                BackContent = CurrentRssSearchResult.Content,
                Count = 0,
                BackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                BackBackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                LogoPath = "Logo-f57c05f7-f831-4da3-9cb9-a68e3f33396b.png"
            };
            return tileInfo;
        }
    }
}