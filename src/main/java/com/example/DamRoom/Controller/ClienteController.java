package com.example.DamRoom.Controller;

import com.example.DamRoom.domain.Cliente;
import com.example.DamRoom.service.ClienteService;
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
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.Set;

@RestController
public class ClienteController {

    @Autowired
    private ClienteService clienteService;

    @Operation(summary = "Obtiene el listado de vuelos y tambien conseguir un vuelo por su origen.")


    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de vuelos",
                    content = @Content(array = @ArraySchema(schema =
                    @Schema(implementation = Cliente.class)))),
    })

    @GetMapping(value = "/clientes/{Dni}}", produces = "application/json")
    public ResponseEntity<Set<Cliente>> getVuelos(@PathVariable String Dni) {
        Set<Cliente> clientes = null;
            clientes = clienteService.findAll();
        return new ResponseEntity<>(clientes, HttpStatus.OK);
    }


}
