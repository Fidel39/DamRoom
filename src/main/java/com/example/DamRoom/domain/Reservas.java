package com.example.DamRoom.domain;


import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.sql.Date;
import java.util.ArrayList;
import java.util.List;


@Data
@Entity
public class Reservas {


    @EmbeddedId
    private ReservasId id ;


    @ManyToOne
    @MapsId("DNICliente")
    private Cliente cliente;


    @ManyToOne
    @MapsId("numHabitacion")
    private Habitacion habitacion;

    @Schema(description = "Fecha de inicio de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private Date fechaIni;


    @Schema(description = "Fecha de finalizacion de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private Date fechaFin;

    @Schema(description = "Precio  de la reserva", example = "450€",
            required = true)
    @NotBlank
    @Column
    private Float importe;

    @Schema(description = "CheckIn de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private boolean checkIn;

    @Schema(description = "CheckOut de la reserva", example = "12/01/2022",
            required = true)
    @NotBlank
    @Column
    private boolean checkOut;

    public Reservas(){
        fechaIni = null;
        fechaFin = null;
        this.importe = 0f;
        this.checkIn = false;
        this.checkOut = false;
        this.id = null;
    }

    public Reservas(ReservasId id,Date FechaIni, Date FechaFin, Float importe, boolean checkIn, boolean checkOut) {
        this.id = id;
        this.fechaIni = FechaIni;
        this.fechaFin = FechaFin;
        this.importe = importe;
        this.checkIn = checkIn;
        this.checkOut = checkOut;
    }



    public Date getFechaIni() {
        return fechaIni;
    }

    public void setFechaIni(Date FechaIni) {
        this.fechaIni = FechaIni;
    }

    public Date getFechaFin() {
        return fechaFin;
    }

    public void setFechaFin(Date FechaFin) {
        this.fechaFin = FechaFin;
    }

    public Float getImporte() {
        return importe;
    }

    public void setImporte(Float importe) {
        this.importe = importe;
    }

    public boolean getCheckIn() {
        return checkIn;
    }

    public void setCheckIn(boolean checkIn) {
        checkIn = checkIn;
    }

    public boolean getCheckOut() {
        return checkOut;
    }

    public void setCheckOut(boolean checkOut) {
        checkOut = checkOut;
    }

    public void setId(ReservasId id) {
        this.id = id;
    }

    public void setId(String dni, long h) {

        this.id = new ReservasId(dni,h);
    }

    @Override
    public String toString() {
        return "Reservas{" +
                ", FechaIni=" + fechaIni +
                ", FechaFin=" + fechaFin +
                ", importe=" + importe +
                ", CheckIn=" + checkIn +
                ", CheckOut=" + checkOut +
                ", cliente=" + cliente +
                '}';
    }
}
