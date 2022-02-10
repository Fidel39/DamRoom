package com.example.DamRoom.domain;


import com.fasterxml.jackson.annotation.JsonIgnore;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import com.fasterxml.jackson.annotation.JsonManagedReference;
import com.fasterxml.jackson.annotation.JsonProperty;
import io.swagger.v3.oas.annotations.media.Schema;
import lombok.Data;
import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

@Data
@Entity
@Table(name = "clientes")
@JsonIgnoreProperties(value = {"reserva"}, allowSetters  = true)
public class Cliente {

    @Schema(description = "Identificador del cliente", example = "48986654L", required = true)
    @Id
    private String dni;

    @Schema(description = "Nombre del cliente", example = "Bartolo", required = true)
    @NotBlank
    @Column
    private String nombre;

    @Schema(description = "Apellido del cliente", example = "Muñoz", required = true)
    @NotBlank
    @Column
    private String apellido;

    @Schema(description = "Direccion del cliente", example = "Calle Falsa numero 2", required = true)
    @NotBlank
    @Column
    private String direccion;

    @Schema(description = "Telefono del cliente", example = "236694365", required = true)
    @NotBlank
    @Column
    private int telefono;

    @OneToMany(mappedBy = "cliente", targetEntity = Reservas.class, cascade = CascadeType.ALL, fetch = FetchType.EAGER)
    @JsonProperty("reserva")
    private List<Reservas> reservaList = new ArrayList<>();


    public Cliente(){
        nombre = "";
        apellido = "";
        direccion = "";
        telefono = 0;
    }

    public Cliente(String dni, String nombre, String apellido, String direccion, int telefono) {
        this.dni = dni;
        this.nombre = nombre;
        this.apellido = apellido;
        this.direccion = direccion;
        this.telefono = telefono;
    }

    public String getDni() {
        return dni;
    }

    public void setDni(String dni) {
        this.dni = dni;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    @Override
    public String toString() {
        return "Cliente{" +
                "dni='" + dni + '\'' +
                ", nombre='" + nombre + '\'' +
                ", apellido='" + apellido + '\'' +
                ", direccion='" + direccion + '\'' +
                ", telefono=" + telefono +
                //", reservasList=" + reservasList +
                '}';
    }
}
