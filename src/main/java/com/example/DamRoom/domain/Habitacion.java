package com.example.DamRoom.domain;


import io.swagger.v3.oas.annotations.media.Schema;
import lombok.Data;
import javax.persistence.*;
import javax.validation.constraints.NotBlank;

@Data
@Entity(name = "habitaciones")
public class Habitacion {


    @Schema(description = "Identificador de la habitacion", example = "1",
            required = true)
    @Id
    private long idRoom;

    @Schema(description = "Tipo de la habitacion", example = "Presidencial",
            required = true)
    @Column
    private String Tipo;


    @Schema(description = "Caracteristicas de la habitacion", example = "Dos camas con una television  y un baño",
            required = true)
    @Column
    private String Caracteristicas;


    @Schema(description = "Precio  de la habitacion", example = "450€",
            required = true)
    @NotBlank
    @Column
    private Float ImporteNoche;

    public Habitacion(long idRoom, String tipo, String caracteristicas, Float importeNoche, Reservas reserva) {
        this.idRoom = idRoom;
        Tipo = tipo;
        Caracteristicas = caracteristicas;
        ImporteNoche = importeNoche;
        this.reserva = reserva;
    }

    @ManyToOne(fetch = FetchType.LAZY)
    private Reservas reserva;

    public long getIdRoom() {
        return idRoom;
    }

    public void setIdRoom(long idRoom) {
        this.idRoom = idRoom;
    }

    public String getTipo() {
        return Tipo;
    }

    public void setTipo(String tipo) {
        Tipo = tipo;
    }

    public String getCaracteristicas() {
        return Caracteristicas;
    }

    public void setCaracteristicas(String caracteristicas) {
        Caracteristicas = caracteristicas;
    }

    public Float getImporteNoche() {
        return ImporteNoche;
    }

    public void setImporteNoche(Float importeNoche) {
        ImporteNoche = importeNoche;
    }

    @Override
    public String toString() {
        return "Habitacion{" +
                "idRoom=" + idRoom +
                ", Tipo='" + Tipo + '\'' +
                ", Caracteristicas='" + Caracteristicas + '\'' +
                ", ImporteNoche=" + ImporteNoche +
                ", reserva=" + reserva +
                '}';
    }
}
