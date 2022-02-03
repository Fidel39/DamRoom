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
@Tag(name = "Reservas", description = "Lista de reservas")
public class ReservasController {
    @Autowired
    private ReservaService reservaService;

    @Operation(summary = "Obtiene el listado de reservas.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de reservas",
                    content = @Content(array = @ArraySchema(schema = @Schema(implementation = Reservas.class)))),
    })
    @GetMapping("/reservas/")
    public ResponseEntity<Set<Reservas>> getReservas(@RequestParam(value =
            "codReserva", defaultValue = "") int codReserva) {
        Set<Reservas> reservas = null;
        if (codReserva == 0)
            reservas = reservaService.findAll();

        return new ResponseEntity<>(reservas, HttpStatus.OK);
    }
}
