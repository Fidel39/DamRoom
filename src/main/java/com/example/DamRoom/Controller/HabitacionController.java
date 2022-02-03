package com.example.DamRoom.Controller;

import com.example.DamRoom.domain.Cliente;
import com.example.DamRoom.domain.Habitacion;
import com.example.DamRoom.service.HabitacionService;
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

import java.util.Set;

@RestController
public class HabitacionController {

    @Autowired
    private HabitacionService habitacionService;

    @Operation(summary = "Obtiene el listado de las habitaciones.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de las habitaciones",
                    content = @Content(array = @ArraySchema(schema =
                    @Schema(implementation = Habitacion.class)))),
    })

    @GetMapping(value = "/damroom/habitaciones", produces = "application/json")
    public ResponseEntity<Set<Habitacion>> getAllRooms() {
        Set<Habitacion> habitacions = null;
        habitacions = habitacionService.findAll();
        return new ResponseEntity<>(habitacions, HttpStatus.OK);
    }

    @Operation(summary = "Registrar una nueva habitacion")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se registra la habitacion", content = @Content(schema = @Schema(implementation = Habitacion.class)))
    })

    @PostMapping(value = "/damroom/habitaciones", produces = "application/json", consumes = "application/json")
    public ResponseEntity<Habitacion> addHabitacion(@RequestBody Habitacion habitacion) {
        Habitacion addedHabitaciones = habitacionService.addHabitacion(habitacion);
        return new ResponseEntity<>(addedHabitaciones, HttpStatus.OK);
    }

    @Operation(summary = "Elimina una Habitacion")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se elimina la habitacion", content = @Content(schema = @Schema(implementation = Response.class))),
            @ApiResponse(responseCode = "404", description = "La habitacion no existe", content = @Content(schema = @Schema(implementation = Response.class)))
    })
    @DeleteMapping("/habitaciones/{idRoom}")
    public ResponseEntity<Response> deleteHabitacion(@PathVariable long idRoom) {
        habitacionService.deleteHabitacion(idRoom);
        return new ResponseEntity<>(Response.noErrorResponse(),
                HttpStatus.OK);
    }

}
