package com.example.DamRoom.Controller;


import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.service.ReservaService;
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
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.Set;

@RestController
@Tag(name = "Vuelos", description = "Catálogo de vuelos")
public class ReservasController {
    @Autowired
    private ReservaService reservaService;

    @Operation(summary = "Obtiene el listado de vuelos por origen")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de vuelos",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })
    @GetMapping("/vueloId")
    public ResponseEntity<Set<Reservas>> getReservas(@RequestParam(value =
            "id", defaultValue = "") int id) {
        Set<Reservas> vuelos = null;
        if (id == 0)
            vuelos = reservaService.findAll();
        else
            vuelos = reservaService.findById(id);
        return new ResponseEntity<>(vuelos, HttpStatus.OK);
    }
}
