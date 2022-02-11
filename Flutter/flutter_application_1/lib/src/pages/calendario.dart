import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_calendar/calendar.dart';

class Calendario extends StatelessWidget{
  
  @override
  Widget build(BuildContext context){
    return Scaffold(
      appBar: AppBar(
        centerTitle: true,
        title: Text("Todas las reservas"),
      ),
      body: SfCalendar(
        view: CalendarView.week,
        dataSource: MeetingDateSource(getAppointment()),
      ),
    );
  }
}

List<Appointment> getAppointment(){
  List<Appointment> reserva = <Appointment>[];
  final DateTime starTime = DateTime(2022,2,12,13,00);
  final DateTime endTime = starTime.add(const Duration(days: 2));

  reserva.add(Appointment(
    startTime: starTime,
    endTime: endTime,
    subject: 'Reserva habitacion 3',
    color: Colors.blue
  ));
  
  return reserva;
}

class MeetingDateSource extends CalendarDataSource{
  MeetingDateSource(List<Appointment> source){
    appointments = source;
  } 
}