// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ServiceLocator.tt
using WPAppStudio.Ioc;
using WPAppStudio.Ioc.Interfaces;
using WPAppStudio.ViewModel;
using WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of the ViewModel locator service based on IoC.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class ViewModelLocatorService
    {
        // IoC container
        private readonly IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocatorService" /> class.
        /// </summary>
        public ViewModelLocatorService()
        {
            _container = new Container();
        }

        /// <summary>
        /// Gets the reference to a StudyAbroad_NewsViewModel.
        /// </summary>
		public IStudyAbroad_NewsViewModel StudyAbroad_NewsViewModel
        {
            get { return _container.Resolve<StudyAbroad_NewsViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a Windows8_DetailViewModel.
        /// </summary>
		public IWindows8_DetailViewModel Windows8_DetailViewModel
        {
            get { return _container.Resolve<Windows8_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a WindowsPhone_DetailViewModel.
        /// </summary>
		public IWindowsPhone_DetailViewModel WindowsPhone_DetailViewModel
        {
            get { return _container.Resolve<WindowsPhone_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a News_DetailViewModel.
        /// </summary>
		public INews_DetailViewModel News_DetailViewModel
        {
            get { return _container.Resolve<News_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a StudyAbroad_DetailViewModel.
        /// </summary>
		public IStudyAbroad_DetailViewModel StudyAbroad_DetailViewModel
        {
            get { return _container.Resolve<StudyAbroad_DetailViewModel>(); }
        }
    }
}
