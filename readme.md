#GridView

The issue is in the presentation of data in the ZoomedIn view - check `MainPage.xaml` and look for the `ItemsPanelTemplate` in the ZoomedInView.

Swap out the `<StackPanel />` for a `<VirtualizingStackPanel />` for interesting results...