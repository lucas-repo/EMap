﻿using EM.GIS.Data;
using EM.GIS.Geometries;
using EM.GIS.Symbology;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace EM.GIS.Controls
{
    /// <summary>
    /// 地图接口
    /// </summary>
    public interface IMap : IProj
    {
        /// <summary>
        /// 视图范围
        /// </summary>
        IExtent ViewExtent { get; set; }
        /// <summary>
        /// 视图边界
        /// </summary>
        Rectangle ViewBound { get; set; }
        /// <summary>
        /// 是否在工作中
        /// </summary>
        bool IsBusy { get; set; }
        /// <summary>
        /// 图例
        /// </summary>
        ILegend Legend { get; set; }
        /// <summary>
        /// 重绘指定范围
        /// </summary>
        /// <param name="extent"></param>
        void Invalidate(IExtent extent);
        /// <summary>
        /// 重绘整个地图
        /// </summary>
        void Invalidate();
        /// <summary>
        /// 缩放至最大范围
        /// </summary>
        void ZoomToMaxExtent();
        /// <summary>
        /// 地图框架
        /// </summary>
        IFrame MapFrame { get; set; }
        /// <summary>
        /// 添加多个图层
        /// </summary>
        /// <returns></returns>
        IList<ILayer> AddLayers();
        /// <summary>
        /// 添加单个图层
        /// </summary>
        /// <returns></returns>
        ILayer AddLayer();
        /// <summary>
        /// 图层
        /// </summary>
        ILayerCollection Layers { get; }
        /// <summary>
        /// 地图方法
        /// </summary>
        List<ITool> MapTools { get; }
        /// <summary>
        /// 激活地图方法
        /// </summary>
        /// <param name="function"></param>
        void ActivateMapFunction(ITool function);
        /// <summary>
        /// 使所有地图工具无效
        /// </summary>
        void DeactivateAllMapTools();

        #region 事件
        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        event EventHandler<IGeoMouseEventArgs> GeoMouseMove;
        #endregion
    }
}
