import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class HomeReservas extends StatelessWidget{

@override
  Widget build(BuildContext context){
    return Scaffold(
      appBar: AppBar(
        centerTitle: true,
        title: Text('Reservas'),
        backgroundColor: Colors.cyanAccent,
      ),
    );
  }
}