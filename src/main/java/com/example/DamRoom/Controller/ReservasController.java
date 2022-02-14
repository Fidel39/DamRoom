package com.example.DamRoom.Controller;


import com.example.DamRoom.domain.Habitacion;
import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.service.*;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.media.ArraySchema;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Optional;
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

    @GetMapping("/reservas/idReserva/{id}")
    public ResponseEntity<Optional<Reservas>> getReservaById(@PathVariable long id) {
        Optional<Reservas> reservas = null;
        reservas = reservaService.findReservaByidReserva(id);
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }


    @Operation(summary = "Obtiene una reserva por su fecha de inicio de la reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/reservas/fechaIni")
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

    @GetMapping("/reservas/fechaFinal")
    public ResponseEntity<Set<Reservas>> getReservaByFechaFin(@RequestParam(value = "fechaFinal", defaultValue = "")String fechaFin) {
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

    @GetMapping("/reservas/{importe}")
    public ResponseEntity<Set<Reservas>> getReservaByImporte(@PathVariable float importe) {
        Set<Reservas> reservas = null;
            reservas = reservaService.findReservaByimporte(importe);
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }


    @Operation(summary = "Obtiene una reserva por el estado.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/reservas/estado")
    public ResponseEntity<Set<Reservas>> getReservaestado(@RequestParam(value = "estado", defaultValue = "")String estado) {
        Set<Reservas> reservas = null;
        reservas = reservaService.findReservasByestado(estado);
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }


    @Operation(summary = "Obtiene todas las reservas de un cliente.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas/{dniCliente}")
    public ResponseEntity<Set<Reservas>> getReservasByDniCliente(@PathVariable String dniCliente) {
        Set<Reservas> reservas = null;
        reservas = reservaService.findReservaBydniCliente(dniCliente);
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }


    @Operation(summary = "Obtiene todas las reservas de un año.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })

    @GetMapping("/damroom/reservas/reservasAnuales/{anyo}")
    public ResponseEntity<Set<Reservas>> getReservasAnuales(@PathVariable String anyo) {
        Set<Reservas> reservas = null;
        reservas = reservaService.estadisticaReservasAnuales(anyo);
        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }




    @Operation(summary = "Registrar una nueva reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se registra la habitacion", content = @Content(schema = @Schema(implementation = Habitacion.class)))
    })

    @PostMapping(value = "/damroom/reservas" , produces = "application/json", consumes = "application/json")
    public ResponseEntity<Reservas> addReserva(@RequestBody Reservas reserva){
        Reservas addedReserva = reservaService.addReserva(reserva);
        return new ResponseEntity<>(addedReserva , HttpStatus.OK);

    }


    @Operation(summary = "Modifica una reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se registra la habitacion", content = @Content(schema = @Schema(implementation = Habitacion.class)))
    })

    @PutMapping(value = "/reservas/{idReserva}" , produces = "application/json", consumes = "application/json")
    public ResponseEntity<Reservas> modifyReserva(@PathVariable long idReserva,@RequestBody Reservas reserva){
        Reservas modifyReserva = reservaService.modifyReserva(idReserva,reserva);
        return new ResponseEntity<>(modifyReserva , HttpStatus.OK);

    }

    @Operation(summary = "Elimina una reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se registra la habitacion", content = @Content(schema = @Schema(implementation = Habitacion.class)))
    })



    @DeleteMapping("/reservas/{idReserva}")
    public ResponseEntity<Response> deleteReserva(@PathVariable long idReserva) {
        reservaService.deleteReserva(idReserva);
        return new ResponseEntity<>(Response.noErrorResponse(), HttpStatus.OK);
    }


    @Operation(summary = "Cambio de estado de una reserva.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se registra la habitacion", content = @Content(schema = @Schema(implementation = Habitacion.class)))
    })

    @PutMapping(value = "/reservas/checkIn" , produces = "application/json", consumes = "application/json")
    public ResponseEntity<Reservas> checkReserva(@RequestParam(value = "checkIn", defaultValue = "")String checkIn,@RequestBody Reservas reserva){
        Reservas modifyReserva = reservaService.checkReserva(checkIn,reserva);
        return new ResponseEntity<>(modifyReserva , HttpStatus.OK);

    }




}
