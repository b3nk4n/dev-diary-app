// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPAppStudio.Entities.Base;
using WPAppStudio.Repositories.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// RSS data source.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class StudyAbroadDS : IStudyAbroadDS 
    {
        private IXmlDataSource _xmlDataSource; 
        private ObservableCollection<RssSearchResult> _data = new ObservableCollection<RssSearchResult>();

        private const string RssUrl = "http://bsautermeister.blogspot.com/feeds/posts/default/-/Study%20Abroad?alt=rss";

        /// <summary>
        /// Initializes a new instance of the <see cref="StudyAbroadDS" /> class.
        /// </summary>
        /// <param name="xmlDataSource">A XML based data source.</param>
        public StudyAbroadDS(IXmlDataSource xmlDataSource)
        {
            _xmlDataSource = xmlDataSource;
        }

        /// <summary>
        /// Retrieves the data from a RSS data source (http://bsautermeister.blogspot.com/feeds/posts/default/-/Study%20Abroad), in an observable collection of RssSearchResult items.
        /// </summary>
        /// <returns>An observable collection of RssSearchResult items.</returns>
        public async Task<ObservableCollection<RssSearchResult>> GetData()
        {
            return await LoadData();
        }
						
		/// <summary>
        /// Retrieves the data from a RSS data source (http://bsautermeister.blogspot.com/feeds/posts/default/-/Study%20Abroad), filtered by a filter specification, in an observable collection of RssSearchResult items.
        /// </summary>
		/// <param name="filter">Filter operation specification</param>
        /// <returns>An observable collection of RssSearchResult items.</returns>
        public async Task<ObservableCollection<RssSearchResult>> Search(FilterSpecification filter)
        {
			var data = await LoadData();
            return Filter<RssSearchResult>.FilterCollection(filter, data);
        }

        private async Task<ObservableCollection<RssSearchResult>> LoadData()
        {
            var feed = await _xmlDataSource.LoadRemote<System.ServiceModel.Syndication.SyndicationFeed>(RssUrl);
			var defaultImage = feed.ImageUrl != null ? feed.ImageUrl.AbsoluteUri : null;
            return feed != null && feed.Items != null ? new ObservableCollection<RssSearchResult>(feed.Items.Select(i=>new RssSearchResult(i, defaultImage))) : new ObservableCollection<RssSearchResult>();
        }
	}	
}