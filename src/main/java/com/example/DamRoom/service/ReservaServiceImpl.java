package com.example.DamRoom.service;

import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.exception.ReservaNotFoundException;
import com.example.DamRoom.repository.ClienteRepository;
import com.example.DamRoom.repository.HabitacionRepository;
import com.example.DamRoom.repository.ReservaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.Date;
import java.util.Set;
import java.util.Optional;

@Service
@Transactional
public class ReservaServiceImpl implements ReservaService{

    @Autowired
    private ReservaRepository reservaRepository;
    private ClienteRepository clienteRepository;
    private HabitacionRepository habitacionRepository;

    @Override
    public Set<Reservas> findAll() {
        return reservaRepository.findAll();
    }


    @Override
    public Set<Reservas> findReservaByfechaIni(Date fechaIni){
        return reservaRepository.findReservaByfechaIni(fechaIni);
    }

    @Override
    public Set<Reservas> findReservaByfechaFin(Date fechaFin){
        return reservaRepository.findReservaByfechaFin(fechaFin);
    }

    @Override
    public Set<Reservas> findReservaByimporte(float importe){
        return reservaRepository.findReservaByimporte(importe);
    }

    @Override
    public Set<Reservas> findReservasByestado(String estado) {
        return reservaRepository.findReservaByestado(estado);
    }

    @Override
    public Optional<Reservas> findReservaByidReserva(long idReserva){
        return reservaRepository.findReservaByidReserva(idReserva);
    }


    @Override
    public Reservas addReserva(Reservas reservas){

        return reservaRepository.save(reservas);
    }

    @Override
    public Reservas modifyReserva(long idReserva, Reservas newReserva){
        Reservas reservas = reservaRepository.findReservaByidReserva(idReserva)
                .orElseThrow(() -> new ReservaNotFoundException(idReserva));
        newReserva.setIdReserva(reservas.getIdReserva());
        return reservaRepository.save(newReserva);
    }

    @Override
    public void deleteReserva(long idReserva) {
        Reservas reservas = reservaRepository.findReservaByidReserva(idReserva)
                .orElseThrow(() -> new ReservaNotFoundException(idReserva));
        reservaRepository.delete(reservas);
    }

    @Override
    public Reservas checkReserva(String check,long idReserva) {
        Reservas reservas = reservaRepository.findReservaByidReserva(idReserva)
                .orElseThrow(() -> new ReservaNotFoundException(idReserva));

        if(reservas.getEstado().equals("Pendiente")&&check.equals("CheckIn")){
            reservas.setEstado("En Activo");
        }else if(reservas.getEstado().equals("En Activo")&&check.equals("CheckOut")){
            reservas.setEstado("Finalizado");
        }
        Long id = reservas.getIdReserva();
        return reservas;
    }
}
