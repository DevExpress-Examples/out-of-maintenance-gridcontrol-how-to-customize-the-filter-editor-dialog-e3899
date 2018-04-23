# GridControl - How to customize the Filter Editor dialog


<p>You can invoke the Filter Editor dialog by clicking a column header and choosing the<strong> </strong><strong>Filter Editor</strong> item. In some scenarios, it is useful to add additional buttons to this dialog, i.e. customize it.<br />
This example illustrates how to add the additional "CustomAction" button to this dialog. For this, it is necessary to handle the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridDataViewBase_FilterEditorCreatedtopic"><u>DataViewBase.FilterEditorCreated event</u></a>.  Set the e.Handled property to true and show your own Filter Editor dialog in this event handler.    </p>

<br/>


