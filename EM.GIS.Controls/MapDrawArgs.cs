﻿using EM.GIS.Symbology;
using System;
using System.Drawing;

namespace EM.GIS.Controls
{
    public class MapDrawArgs : EventArgs
    {
        #region Fields

        private Rectangle _clipRectangle;
        private MapEventArgs _geoGraphics;
        private Graphics _graphics;

        #endregion

        #region  Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapDrawArgs"/> class.
        /// </summary>
        /// <param name="inGraphics">The graphics object used for drawing.</param>
        /// <param name="clipRectangle">The clip rectangle.</param>
        /// <param name="inMapFrame">The map frame.</param>
        public MapDrawArgs(Graphics inGraphics, Rectangle clipRectangle, IFrame inMapFrame)
        {
            _graphics = inGraphics;
            _geoGraphics = new MapEventArgs(clipRectangle, inMapFrame.ViewExtent);

            _clipRectangle = clipRectangle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapDrawArgs"/> class.
        /// </summary>
        /// <param name="inGraphics">The graphics object used for drawing.</param>
        /// <param name="clipRectangle">The clip rectangle.</param>
        /// <param name="inGeoGraphics">The map args.</param>
        public MapDrawArgs(Graphics inGraphics, Rectangle clipRectangle, MapEventArgs inGeoGraphics)
        {
            _graphics = inGraphics;
            _clipRectangle = clipRectangle;
            _geoGraphics = inGeoGraphics;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the clip rectangle that defines the area on the region in client coordinates where drawing is taking place.
        /// </summary>
        public virtual Rectangle ClipRectangle
        {
            get
            {
                return _clipRectangle;
            }

            set
            {
                _clipRectangle = value;
            }
        }

        /// <summary>
        /// Gets or sets a GeoGraphics wrapper that makes it easy to draw things in geographic coordinates.
        /// </summary>
        public virtual MapEventArgs GeoGraphics
        {
            get
            {
                return _geoGraphics;
            }

            protected set
            {
                _geoGraphics = value;
            }
        }

        /// <summary>
        /// Gets or sets a Graphics object that is useful for drawing in client coordinates. Coordinates
        /// should be specified as though they were drawn to the client rectangle, even if
        /// a clip rectangle is specified.
        /// </summary>
        public virtual Graphics Graphics
        {
            get
            {
                return _graphics;
            }

            protected set
            {
                _graphics = value;
            }
        }

        #endregion
    }
}