// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   UnityContainer.tt
using Microsoft.Practices.Unity;
using WPAppStudio.Ioc.Interfaces;
using WPAppStudio.Repositories;
using WPAppStudio.Repositories.Base;
using WPAppStudio.Services;
using WPAppStudio.Services.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Ioc
{
    //
    // Unity 2.1
    // http://msdn.microsoft.com/en-us/library/hh237493.aspx
    //
    // patterns & practices - Unity
    // http://unity.codeplex.com/
    //
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class Container : IContainer
    {
        private readonly IUnityContainer _currentContainer;

        public Container()
        {
            _currentContainer = new UnityContainer();

            _currentContainer.RegisterType<ILiveTileService, LiveTileService>();
			_currentContainer.RegisterType<ILockScreenService, LockScreenService>();
            _currentContainer.RegisterType<IDialogService, DialogService>();
            _currentContainer.RegisterType<IReminderService, ReminderService>();
            _currentContainer.RegisterType<IShareService, ShareService>();
            _currentContainer.RegisterType<ISpeechService, SpeechService>();
            _currentContainer.RegisterType<INavigationService, NavigationService>();
			_currentContainer.RegisterType<IJsonDataSource, JsonDataSource>();
			_currentContainer.RegisterType<IXmlDataSource, XmlDataSource>();
			_currentContainer.RegisterType<IYoutubeDataSource, YoutubeDataSource>();
			
            _currentContainer.RegisterType<IStudyAbroad_NewsViewModel, StudyAbroad_NewsViewModel>();
            _currentContainer.RegisterType<IStudyAbroad_DetailViewModel, StudyAbroad_DetailViewModel>();
            _currentContainer.RegisterType<IWindows8_DetailViewModel, Windows8_DetailViewModel>();
            _currentContainer.RegisterType<IWindowsPhone_DetailViewModel, WindowsPhone_DetailViewModel>();
            _currentContainer.RegisterType<INews_DetailViewModel, News_DetailViewModel>();
            
			
			if (!System.ComponentModel.DesignerProperties.IsInDesignTool)
            {
                _currentContainer.RegisterType<INewsDS, NewsDS>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IStudyAbroadDS, StudyAbroadDS>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IWindowsPhoneDS, WindowsPhoneDS>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IWindows8DS, Windows8DS>(new ContainerControlledLifetimeManager());
			}
			else
			{
                _currentContainer.RegisterType<INewsDS, FakeNewsDS>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IStudyAbroadDS, FakeStudyAbroadDS>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IWindowsPhoneDS, FakeWindowsPhoneDS>(new ContainerControlledLifetimeManager());
				_currentContainer.RegisterType<IWindows8DS, FakeWindows8DS>(new ContainerControlledLifetimeManager());
			}	
        }

        public T Resolve<T>()
        {
            return _currentContainer.Resolve<T>();
        }
    }
}
