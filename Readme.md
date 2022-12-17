<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128647754/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3899)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [FilterWindow.xaml](./CS/FilterWindow.xaml) (VB: [FilterWindow.xaml](./VB/FilterWindow.xaml))
* [FilterWindow.xaml.cs](./CS/FilterWindow.xaml.cs) (VB: [FilterWindow.xaml.vb](./VB/FilterWindow.xaml.vb))
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel.vb))
<!-- default file list end -->
# GridControl - How to customize the Filter Editor dialog


You can invoke the Filter Editor dialog by clicking a column header and choosing the **Filter Editor** item. In some scenarios, it is useful to add additional buttons to this dialog, i.e. customize it.

This example illustrates how to add the additional "CustomAction" button to this dialog. For this, it is necessary to handle the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridDataViewBase_FilterEditorCreatedtopic"><u>DataViewBase.FilterEditorCreated event</u></a>.  Set the **e.Handled** property to **true** and show your own Filter Editor dialog in this event handler.

**Note**: The GridControl uses the ***new*** Filter Editor starting from **v19.1**. To enable the ***previous*** Filter Editor, set the [DataViewBase.UseLegacyFilterEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.UseLegacyFilterEditor) property to **true**. 

Refer to the [Filter Editor](https://docs.devexpress.com/WPF/7788/controls-and-libraries/data-grid/filtering-and-searching/filter-editor) article for information on how to customize the ***new*** Filter Editor.
