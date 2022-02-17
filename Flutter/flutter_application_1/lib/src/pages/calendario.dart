import 'package:flutter/material.dart';
import 'package:flutter_application_1/src/providers/reservas_providers.dart';


class Calendario extends StatefulWidget {
  @override
  _CalendarioState createState() => _CalendarioState();
}

class _CalendarioState extends State<Calendario>{
    
    TextEditingController _inputFieldDateController = new TextEditingController();
    String _fecha = '';
  @override
  Widget build(BuildContext context){
    return Scaffold(
      appBar: AppBar(
        centerTitle: true,
        title: Text("Todas las reservas"),
        backgroundColor: Colors.black,
        actions: [
          IconButton(
            icon: Icon(Icons.date_range_outlined),
            onPressed: (){
                _crearReservas();
            }
          )
        ],
      ),
      body: Container(
        child:  SingleChildScrollView(
          child: Column(
            mainAxisAlignment: MainAxisAlignment.spaceAround,
            children: [
              Divider(),
              _crearFecha(context),
      
            ],),
        )
      ),
    );
  }




Widget _crearReservas(){
  final reservasProvider = ReservasProvider();

  return FutureBuilder(
    future: reservasProvider.getReservasPorFechaIni(_fecha),
    builder: (BuildContext context, AsyncSnapshot<List> snapshot){
      if(snapshot.hasData){
        return _listaReservas(snapshot.data!);
      }else{
        return const Center(
          child: CircularProgressIndicator(),
        );
      }
    }
  );
}


Widget _listaReservas(List<dynamic> reservas){
  return ListView.builder(
    physics: const NeverScrollableScrollPhysics(),
    shrinkWrap: true,
    itemCount: reservas.length,
    itemBuilder: (BuildContext context, int index){
        final codReserva = reservas[index].idReservas;
        final fechaInicio = reservas[index].fechaIni;
        final fechaFin = reservas[index].fechaFin;
        final importe = reservas[index].importe;
        final dniCliente = reservas[index].dniCliente;
        final caracteristicas = reservas[index].caracteristicas;
        final cliente = reservas[index].cliente;
        final habitacion = reservas[index].habitacion;
        
        return Container(
          child: Row(
            children: [
              Text("Dni Cliente: "+dniCliente,),
            ],
          ),
        );
    }
  );
}


  Widget _crearFecha(BuildContext context) {
    return TextField(
      enableInteractiveSelection: false,
      controller: _inputFieldDateController,
      decoration: InputDecoration(
          hintText: 'Fecha de inicio de la reserva.',
          labelText: 'Fecha de inicio de la reserva.',
          suffixIcon: Icon(Icons.perm_contact_calendar),
          icon: Icon(Icons.calendar_today),
          border: OutlineInputBorder(borderRadius: BorderRadius.circular(20))),
      onTap: () {
        FocusScope.of(context).requestFocus(new FocusNode());
        _selectDate(context);
      },
    );
  }

  _selectDate(BuildContext context) async {
    DateTime? picked = await showDatePicker(
        context: context,
        initialDate: new DateTime.now(),
        firstDate: new DateTime(2018),
        lastDate: new DateTime(2025));
    if (picked != null) {
      setState(() {
        _fecha = picked.toString();
        print(_fecha);
        _inputFieldDateController.text = _fecha;
      });
    }
  }
}