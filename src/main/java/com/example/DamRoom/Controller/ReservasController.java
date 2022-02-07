package com.example.DamRoom.Controller;


import com.example.DamRoom.domain.Cliente;
import com.example.DamRoom.domain.Habitacion;
import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.domain.ReservasId;
import com.example.DamRoom.exception.ClienteNotFoundException;
import com.example.DamRoom.exception.HabitacionNotFoundException;
import com.example.DamRoom.service.*;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.media.ArraySchema;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import io.swagger.v3.oas.annotations.tags.Tag;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Optional;
import java.util.OptionalInt;
import java.util.Set;

@RestController
public class ReservasController {

    @Autowired
    private ReservaService reservaService;
    private ClienteServiceImpl clienteService;
    private HabitacionServiceImpl habitacionService;

    public ReservasController() {
        clienteService = new ClienteServiceImpl();
        habitacionService = new HabitacionServiceImpl();
    }

    @Operation(summary = "Obtiene el listado de reservas.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas")
    public ResponseEntity<Set<Reservas>> getReservas() {
        Set<Reservas> reservas = null;
            reservas = reservaService.findAll();
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }



    @Operation(summary = "Obtiene una reserva por su id.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas/dni,numHabitacion")
    public ResponseEntity<Optional<Reservas>> getReservaById(@RequestParam(value = "dni", defaultValue = "")String dni, @RequestParam(value = "numHabitacion", defaultValue = "")long numHabitacion) {
        Optional<Reservas> reservas = null;
        reservas = reservaService.findReservaById(new ReservasId(dni,numHabitacion));
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }


    @Operation(summary = "Obtiene una reserva por su fecha de inicio de la reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas/fechaIni")
    public ResponseEntity<Set<Reservas>> getReservaByFechaIni(@RequestParam(value = "fechaIni", defaultValue = "")String fechaIni) {
        Set<Reservas> reservas = null;
        SimpleDateFormat formato = new SimpleDateFormat("yyyy-MM-dd");
        try {
            Date fecha = formato.parse(fechaIni);
            reservas = reservaService.findReservaByfechaIni(fecha);

        } catch (ParseException e) {
            e.printStackTrace();
        }
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }


    @Operation(summary = "Obtiene una reserva por su fecha de fin de la reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas/fechaFin")
    public ResponseEntity<Set<Reservas>> getReservaByFechaFin(@RequestParam(value = "fechaFin", defaultValue = "")String fechaFin) {
        Set<Reservas> reservas = null;
        SimpleDateFormat formato = new SimpleDateFormat("yyyy-MM-dd");
        try {
            Date fecha = formato.parse(fechaFin);
            reservas = reservaService.findReservaByfechaFin(fecha);

        } catch (ParseException e) {
            e.printStackTrace();
        }
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }


    @Operation(summary = "Obtiene una reserva por el importe.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas/{importe}")
    public ResponseEntity<Set<Reservas>> getReservaByImporte(@PathVariable float importe) {
        Set<Reservas> reservas = null;
            reservas = reservaService.findReservaByimporte(importe);
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }


    /*@Operation(summary = "Obtiene una reserva por el CheckIn.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas/{checkIn}")
    public ResponseEntity<Set<Reservas>> getReservaByCheckIn(@PathVariable Byte checkIn) {
        Set<Reservas> reservas = null;
        reservas = reservaService.findReservaBycheckIn(checkIn);
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }*/


    @Operation(summary = "Obtiene una reserva por el CheckOut.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas/{checkOut}")
    public ResponseEntity<Set<Reservas>> getReservaByCheckOut(@PathVariable Byte checkOut) {
        Set<Reservas> reservas = null;
        reservas = reservaService.findReservaBycheckOut(checkOut);
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }

    @Operation(summary = "Registrar una nueva reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se registra la habitacion", content = @Content(schema = @Schema(implementation = Habitacion.class)))
    })

    @PostMapping(value = "/damroom/reservas" , produces = "application/json", consumes = "application/json")
    public ResponseEntity<Reservas> addReserva(@RequestBody Reservas reserva){
       /* Cliente clienteReserva = clienteService.findByDni(reserva.getId().getDNICliente())
                .orElseThrow(() -> new ClienteNotFoundException(reserva.getId().getDNICliente()));*/
        Long id_room = reserva.getId().getNumHabitacion();
        Habitacion habitacionReserva = habitacionService.findByIdRoom(id_room)
                .orElseThrow(() -> new HabitacionNotFoundException(reserva.getId().getNumHabitacion()));
        //reserva.setCliente(clienteReserva);
        reserva.setHabitacion(habitacionReserva);
        Reservas addedReserva = reservaService.addReserva(reserva);
        return new ResponseEntity<>(addedReserva , HttpStatus.OK);

    }



    @Operation(summary = "Modifica una reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se registra la habitacion", content = @Content(schema = @Schema(implementation = Habitacion.class)))
    })

    @PutMapping(value = "/damroom/reservas/dni,numHabitacion" , produces = "application/json", consumes = "application/json")
    public ResponseEntity<Reservas> modifyReserva(@RequestParam(value = "dni", defaultValue = "")String dni,@RequestParam(value = "numHabitacion", defaultValue = "")long numHabitacion,@RequestBody Reservas reserva){
        Reservas modifyReserva = reservaService.modifyReserva(new ReservasId(dni,numHabitacion),reserva);
        return new ResponseEntity<>(modifyReserva , HttpStatus.OK);

    }


}
