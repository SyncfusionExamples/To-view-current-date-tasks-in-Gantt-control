# To-view-current-date-tasks-in-Gantt-control

## Description

This article explains how to view the current date tasks in Gantt control at initial loading time.

## Solution

This requirement can be achieved by passing the current date value as a parameter to the ScrollGanttChartTo method.

The following code sample illustrates how to navigate the Gantt chart to the current date.

[C#]

```
private void Gantt_OnLoaded(object sender, RoutedEventArgs e)
{
       //Scroll a Gantt chart to the date
       Gantt.ScrollGanttChartTo(DateTime.Now);
}
```

KB article - [To-view-current-date-tasks-in-Gantt-control](https://www.syncfusion.com/kb/7728/how-to-view-the-gantt-control-with-the-desired-date-tasks-at-load-time-in-wpf)

See also

[To add custom tooltip to gantt](https://help.syncfusion.com/wpf/gantt/customtooltip)

[To define your own schedule for Gantt to track the progress of projects](https://help.syncfusion.com/wpf/gantt/custom-schedule)

[To differentiate the dates of holidays](https://help.syncfusion.com/wpf/gantt/holidays-customization)

