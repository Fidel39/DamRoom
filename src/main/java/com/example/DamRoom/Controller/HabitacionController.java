package com.example.DamRoom.Controller;

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
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

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

    @GetMapping(value = "/habitaciones/{idRoom}}", produces = "application/json")
    public ResponseEntity<Set<Habitacion>> getRooms(@PathVariable Long idRoom) {
        Set<Habitacion> habitacions = null;
        habitacions = habitacionService.findAllRooms();
        return new ResponseEntity<>(habitacions, HttpStatus.OK);
    }

}
