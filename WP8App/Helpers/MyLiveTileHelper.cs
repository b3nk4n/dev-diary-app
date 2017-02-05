using Microsoft.Phone.Shell;
using PhoneKit.Framework.Core.Tile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPAppStudio.Entities.Base;
using WPAppStudio.Resources;

namespace WPAppStudio.Helpers
{
    public static class MyLiveTileHelper
    {
        /// <summary>
        /// Indicates whether already updated to do just one update per app life cycle.
        /// </summary>
        private static bool hasLiveTileUpdated = false;

        /// <summary>
        /// Updates the live tile.
        /// </summary>
        /// <param name="data"></param>
        public static void UpdateLiveTile(RssSearchResult data)
        {
            // verify only updating the live tile once.
            if (hasLiveTileUpdated)
                return;

            FlipTileData tile = new FlipTileData
            {
                Title = AppResources.ApplicationTitle,
                BackgroundImage = new Uri("Assets/Logo336.png", UriKind.Relative),
                WideBackgroundImage = new Uri("Assets/Logo691.png", UriKind.Relative),
                BackBackgroundImage = new Uri("Assets/Logo336.png", UriKind.Relative),
                WideBackBackgroundImage = new Uri("Assets/Logo691.png", UriKind.Relative),
                BackTitle = data.Title
            };

            if (!string.IsNullOrEmpty(data.ImageUrl))
            {
                var imageUri = new Uri(data.ImageUrl, UriKind.Absolute);
                tile.BackBackgroundImage = imageUri;
                tile.WideBackBackgroundImage = imageUri;
            }

            LiveTileHelper.ClearStorage();
            LiveTileHelper.UpdateDefaultTile(tile);

            hasLiveTileUpdated = true;
        }
    }
}
