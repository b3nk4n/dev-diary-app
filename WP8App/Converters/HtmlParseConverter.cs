using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPAppStudio.Converters
{
    public class HtmlParseConverter : IValueConverter
    {
        private const string DOWNLOAD_ALL = "ALLE HERUNTERLADEN";
        private const string ALBUM_SPAN_DEF_TEXT = "Albumnamen hier eingeben";
        private const string ALBUM_IMG = "img";

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var content = value as string;

            if (content != null)
            {
                content = removeDownloadAll(content);

                content = removeAlbumSpan(content);

                content = removeImageLinks(content);

                return content;
            }

            return string.Empty;
        }

        /// <summary>
        /// Removes the IMG links.
        /// </summary>
        /// <param name="content">The html content.</param>
        /// <returns>The reduced html content.</returns>
        private static string removeImageLinks(string content)
        {
            int currentIndex;
            while ((currentIndex = content.IndexOf(ALBUM_IMG)) > 0)
            {
                int tagStartIndex = content.LastIndexOf("<", currentIndex);
                int tagEndIndex = content.IndexOf(">", currentIndex);

                content = content.Remove(tagStartIndex, tagEndIndex - tagStartIndex + 1);
            }
            return content;
        }

        /// <summary>
        /// Removes the album SPAN link.
        /// </summary>
        /// <param name="content">The html content.</param>
        /// <returns>The reduced html content.</returns>
        private static string removeAlbumSpan(string content)
        {
            int currentIndex;
            while ((currentIndex = content.IndexOf(ALBUM_SPAN_DEF_TEXT)) > 0)
            {
                int tagStartIndex = content.LastIndexOf("<", currentIndex);
                int tagEndIndex = content.IndexOf(">", currentIndex);
                int tagNextEndIndex = content.IndexOf(">", tagEndIndex + 1);

                content = content.Remove(tagStartIndex, tagNextEndIndex - tagStartIndex + 1);
            }
            return content;
        }

        /// <summary>
        /// Removes the download all button
        /// </summary>
        /// <param name="content">The html content</param>
        /// <returns>The html content without the download all button.</returns>
        private static string removeDownloadAll(string content)
        {
            while (content.Contains(DOWNLOAD_ALL))
            {
                content = content.Replace(DOWNLOAD_ALL, "");
            }
            return content;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
