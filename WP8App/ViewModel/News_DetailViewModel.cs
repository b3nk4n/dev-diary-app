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
    /// Implementation of News_Detail ViewModel.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public partial class News_DetailViewModel : BindableBase, INews_DetailViewModel, INavigable
    {       

		private readonly IDialogService _dialogService;
		private readonly INavigationService _navigationService;
		private readonly ISpeechService _speechService;
		private readonly IShareService _shareService;
		private readonly ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="News_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public News_DetailViewModel(IDialogService dialogService, INavigationService navigationService, ISpeechService speechService, IShareService shareService, ILiveTileService liveTileService)
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
        /// Delegate method for the TextToSpeechNews_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechNews_DetailStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentRssSearchResult.Title + " " + CurrentRssSearchResult.Content);
        }
		

        private ICommand _textToSpeechNews_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechNews_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechNews_DetailStaticControlCommand
        {
            get { return _textToSpeechNews_DetailStaticControlCommand = _textToSpeechNews_DetailStaticControlCommand ?? new DelegateCommand(TextToSpeechNews_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareNews_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareNews_DetailStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentRssSearchResult.Title, CurrentRssSearchResult.Summary, CurrentRssSearchResult.FeedUrl);
        }
		

        private ICommand _shareNews_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareNews_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareNews_DetailStaticControlCommand
        {
            get { return _shareNews_DetailStaticControlCommand = _shareNews_DetailStaticControlCommand ?? new DelegateCommand(ShareNews_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartNews_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartNews_DetailStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(INews_DetailViewModel), CreateTileInfoNews_DetailStaticControl());
        }
		

        private ICommand _pinToStartNews_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartNews_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartNews_DetailStaticControlCommand
        {
            get { return _pinToStartNews_DetailStaticControlCommand = _pinToStartNews_DetailStaticControlCommand ?? new DelegateCommand(PinToStartNews_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceNews_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceNews_DetailStaticControlCommandDelegate() 
        {
	
				_navigationService.NavigateTo(new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceNews_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceNews_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceNews_DetailStaticControlCommand
        {
            get { return _goToSourceNews_DetailStaticControlCommand = _goToSourceNews_DetailStaticControlCommand ?? new DelegateCommand(GoToSourceNews_DetailStaticControlCommandDelegate); }
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
        /// Initializes a <see cref="TileInfo" /> object for the News_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="TileInfo" /> object.</returns>
        public TileInfo CreateTileInfoNews_DetailStaticControl()
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
