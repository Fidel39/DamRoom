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
import org.springframework.web.bind.annotation.*;

import java.util.Optional;
import java.util.Set;

@RestController
public class ClienteController {

    @Autowired
    private ClienteService clienteService;

    @Operation(summary = "Obtiene el listado de los clientes.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Listado de clientes.",
                    content = @Content(array = @ArraySchema(schema =
                    @Schema(implementation = Cliente.class)))),
    })


    @GetMapping(value = "/damroom/clientes", produces = "application/json")
    public ResponseEntity<Set<Cliente>> getClientes() {
        Set<Cliente> clientes = null;
            clientes = clienteService.findAll();

        return new ResponseEntity<>(clientes, HttpStatus.OK);
    }

    @Operation(summary = "Obtiene el cliente por DNI.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Muestra un cliente.",
                    content = @Content(array = @ArraySchema(schema =
                    @Schema(implementation = Cliente.class)))),
    })


    @GetMapping(value = "/damroom/clientes/{dni}", produces = "application/json")
    public ResponseEntity<Optional<Cliente>> getClientesByDNI(@RequestParam(value = "dni", defaultValue = "") String dni) {
        Optional<Cliente> clientes = null;
        clientes = clienteService.findByDni(dni);

        return new ResponseEntity<>(clientes, HttpStatus.OK);
    }



    @Operation(summary = "Insertar un cliente.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se registra un clientes.",
                    content = @Content(array = @ArraySchema(schema =
                    @Schema(implementation = Cliente.class)))),
    })


    @PostMapping(value = "/damroom/clientes", produces = "application/json", consumes = "application/json")
    public ResponseEntity<Cliente> addCliente(@RequestBody Cliente cliente) {
        Cliente addedClientes = clienteService.addCliente(cliente);
        return new ResponseEntity<>(addedClientes, HttpStatus.OK);
    }

    @Operation(summary = "Modificar un cliente.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se modifica un clientes.",
                    content = @Content(array = @ArraySchema(schema =
                    @Schema(implementation = Cliente.class)))),
    })


    @PutMapping("/clientes/dni")
    public ResponseEntity<Cliente> modificarCliente(@RequestParam( value = "dni", defaultValue = "")String dni, @RequestBody Cliente newCliente) {
        Cliente cliente= clienteService.modificarCliente(dni, newCliente);
        return new ResponseEntity<>(cliente, HttpStatus.OK);
    }


    @Operation(summary = "Eliminar un cliente.")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Se elimina un cliente.",
                    content = @Content(array = @ArraySchema(schema =
                    @Schema(implementation = Cliente.class)))),
    })


    @DeleteMapping("/clientes/dni")
    public ResponseEntity<Response> deleteCliente(@RequestParam( value = "dni", defaultValue = "")String dni) {
        clienteService.deleteCliente(dni);
        return new ResponseEntity<>(Response.noErrorResponse(), HttpStatus.OK);
    }

}
