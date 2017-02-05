// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.Collections.ObjectModel;
using System.Windows.Input;
using WPAppStudio.Controls;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// StudyAbroad_News ViewModel interface.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public interface IStudyAbroad_NewsViewModel
    {		
        /// <summary>
        /// Gets/Sets the StudyAbroad_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<RssSearchResult> StudyAbroad_NewsListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the SelectedStudyAbroad_NewsListControlCollection property.
        /// </summary>
		RssSearchResult SelectedStudyAbroad_NewsListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the News_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<RssSearchResult> News_NewsListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the SelectedNews_NewsListControlCollection property.
        /// </summary>
		RssSearchResult SelectedNews_NewsListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the WindowsPhone_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<RssSearchResult> WindowsPhone_NewsListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the SelectedWindowsPhone_NewsListControlCollection property.
        /// </summary>
		RssSearchResult SelectedWindowsPhone_NewsListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the Windows8_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<RssSearchResult> Windows8_NewsListControlCollection { get; set; }

        /// <summary>
        /// Gets/Sets the SelectedWindows8_NewsListControlCollection property.
        /// </summary>
		RssSearchResult SelectedWindows8_NewsListControlCollection { get; set; }

        
        /// <summary>
        /// Gets the RefreshStudyAbroad_NewsListControlCollection command.
        /// </summary>
		ICommand RefreshStudyAbroad_NewsListControlCollection { get; }

        
        /// <summary>
        /// Gets the RefreshNews_NewsListControlCollection command.
        /// </summary>
		ICommand RefreshNews_NewsListControlCollection { get; }

        
        /// <summary>
        /// Gets the RefreshWindowsPhone_NewsListControlCollection command.
        /// </summary>
		ICommand RefreshWindowsPhone_NewsListControlCollection { get; }

        
        /// <summary>
        /// Gets the RefreshWindows8_NewsListControlCollection command.
        /// </summary>
		ICommand RefreshWindows8_NewsListControlCollection { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

	}
}
